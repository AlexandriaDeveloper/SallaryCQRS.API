using Application.Common;
using Application.Interfaces;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries
{
    public class GetDeltetdEmployeeListQueryParam : Param
    {
        public string? Name { get; set; }
        public string? TabCode { get; set; }
        public string? TegaraCode { get; set; }

        public string? NationalId { get; set; }
    };
    public record GetDeletedEmployeesQuery (GetDeltetdEmployeeListQueryParam param) :IRequest<IReadOnlyList<Employee>>;
    public class GetDeletedEmployeesQueryHandler : IRequestHandler<GetDeletedEmployeesQuery, IReadOnlyList<Employee>>
    {
        private readonly IUOW _uow;

        public GetDeletedEmployeesQueryHandler(IUOW uow)
        {
            this._uow = uow;
        }
        public async Task<IReadOnlyList<Employee>> Handle(GetDeletedEmployeesQuery request, CancellationToken cancellationToken)
        {
            var spec = new GetDeletedEmployeeListQuerySpecification(request.param);
            return await _uow.EmployeeRepository.GetAlDeletedlAsync(spec);
        }



        internal class GetDeletedEmployeeListQuerySpecification : Specification<Employee>
        {
            public GetDeletedEmployeeListQuerySpecification(GetDeltetdEmployeeListQueryParam param) : base()
            {
                if (!string.IsNullOrEmpty(param.Name))
                {
                    AddCriteries(x => x.Name.Contains(param.Name));
                }
                if (!string.IsNullOrEmpty(param.TabCode))
                {
                    AddCriteries(x => x.TabCode.Equals(param.TabCode));
                }
                if (!string.IsNullOrEmpty(param.TegaraCode))
                {
                    AddCriteries(x => x.TegaraCode.Equals(param.TegaraCode));
                }
                if (!string.IsNullOrEmpty(param.NationalId))
                {
                    AddCriteries(x => x.NationalId.Equals(param.NationalId));
                }

            }
        }
    }


}
