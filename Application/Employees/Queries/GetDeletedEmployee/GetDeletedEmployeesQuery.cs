using Domain.Shared;
using Domain.Interfaces;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Messaging;

namespace Domain.Employees.Queries.GetDeletedEmployee
{
    public class GetDeltetdEmployeeListQueryParam : Param
    {
        public string? Name { get; set; }
        public string? TabCode { get; set; }
        public string? TegaraCode { get; set; }

        public string? NationalId { get; set; }
    };
    public record GetDeletedEmployeesQuery(GetDeltetdEmployeeListQueryParam param) : IQuery<IReadOnlyList<Employee>>;
    public partial class GetDeletedEmployeesQueryHandler : IQueryHandler<GetDeletedEmployeesQuery, IReadOnlyList<Employee>>
    {
        private new readonly IUOW _uow;

        public GetDeletedEmployeesQueryHandler(IUOW uow) 
        {
            _uow = uow;
        }
        public  async Task<Result<IReadOnlyList<Employee>>> Handle(GetDeletedEmployeesQuery request, CancellationToken cancellationToken)
        {
            var spec = new GetDeletedEmployeeListQuerySpecification(request.param);
            return Result<IReadOnlyList<Employee>>.Success(await _uow.EmployeeRepository.GetAlDeletedlAsync(spec));
        }
    }


}
