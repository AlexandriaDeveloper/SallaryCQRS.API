using Application.Common;

using Application.Interfaces;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmployeeGrades.Query.GetEmployeeCurrentGrade
{
    public record GetEmployeeCurrentGradeQuery(int employeeId):IRequest<Result<EmployeeGradeDto>>;
    public class GetEmployeeCurrentGradeQueryHandler : Handler<GetEmployeeCurrentGradeQuery, Result<EmployeeGradeDto>>
    {
        public GetEmployeeCurrentGradeQueryHandler(IUOW uow) : base(uow)
        {
        }

        
        public override async Task<Result<EmployeeGradeDto>> Handle(GetEmployeeCurrentGradeQuery request, CancellationToken cancellationToken)
        {

            var validation = new GetEmployeeCurrentGradeQueryHandlerValidator();
            var validate = await validation.ValidateAsync(request, cancellationToken);
            if (!validate.IsValid)
            {
                return Result<EmployeeGradeDto>.Failure(validate.Errors.First().ErrorMessage);
            }
            var grade = await _uow.EmployeeGradeRepository.GetEmployeeCurrentGrade(request.employeeId);
            if (grade == null) {
                return Result<EmployeeGradeDto>.Failure("Employee Dosent Containe Grade Yet");
            }

            EmployeeGradeDto employeeGrade= new EmployeeGradeDto();

            employeeGrade.EmployeeName = grade.Employees.Name;
            employeeGrade.GradeName = grade.Grade.Name;
            employeeGrade.StartFrom= grade.StartFrom;
            employeeGrade.EndAt= grade.EndAt;
            return Result<EmployeeGradeDto>.Success(employeeGrade);
        }
    }
}
