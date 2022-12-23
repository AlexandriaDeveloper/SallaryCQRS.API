using Domain.Shared;
using Domain.Employees.Queries.GetEmployeeById;
using Domain.Interfaces;
using Domain.Models;
using Domain.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Messaging;
using Domain.Common;

namespace Domain.EmployeeGrades.Query.GetEmployeeInSpecificGradeId
{
    public record GetEmployeesInSpecificGradeIdQuery(int gradeId): IQuery<List<Employee>>;
    public class GetEmployeeInSpecificGradeIdQueryHandler : IQueryHandler<GetEmployeesInSpecificGradeIdQuery, List<Employee>>
    {
        private readonly IUOW _uow;

        public GetEmployeeInSpecificGradeIdQueryHandler(IUOW uow) 
        {
            _uow = uow;
        }

        public async  Task<Result<List<Employee>>> Handle(GetEmployeesInSpecificGradeIdQuery request, CancellationToken cancellationToken)
        {
            var gradeExist =await _uow.GradeRepository.GetByIdAsync(request.gradeId);
            if(gradeExist == null)
            {
              return  Result<List<Employee>>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            var result = await _uow.EmployeeGradeRepository.GetEmployeeInSpecificGradeId(request.gradeId);
            return  Result<List<Employee>>.Success(await _uow.EmployeeGradeRepository.GetEmployeeInSpecificGradeId(request.gradeId));
        }
    }
}
