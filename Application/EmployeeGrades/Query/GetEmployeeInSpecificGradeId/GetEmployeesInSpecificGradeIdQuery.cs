using Application.Common;
using Application.Employees.Queries.GetEmployeeById;
using Application.Interfaces;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmployeeGrades.Query.GetEmployeeInSpecificGradeId
{
    public record GetEmployeesInSpecificGradeIdQuery(int gradeId): IRequest<Result<List<Employee>>>;
    public class GetEmployeeInSpecificGradeIdQueryHandler : Handler<GetEmployeesInSpecificGradeIdQuery, Result<List<Employee>>>
    {
        public GetEmployeeInSpecificGradeIdQueryHandler(IUOW uow) : base(uow)
        {
        }

        public async override Task<Result<List<Employee>>> Handle(GetEmployeesInSpecificGradeIdQuery request, CancellationToken cancellationToken)
        {
            var validation = new GetEmployeesInSpecificGradeIdQueryValidator();
            var validate = await validation.ValidateAsync(request, cancellationToken);
            if (!validate.IsValid)
            {
                return Result<List<Employee>>.Failure(validate.Errors.First().ErrorMessage);
            }
            return  Result<List<Employee>>.Success(await _uow.EmployeeGradeRepository.GetEmployeeInSpecificGradeId(request.gradeId));
        }
    }
}
