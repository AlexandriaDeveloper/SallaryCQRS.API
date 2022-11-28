using MediatR;
using Domain.Models;
using Application.Interfaces;
using Application.Common;

namespace Application.Employees.Queries
{
    public record GetEmployeesByIdQuery(Guid Id) : IRequest<Employee>;

    public class GetEmployeesByIdQueryHandler : Handler<GetEmployeesByIdQuery, Employee>
    {
        public GetEmployeesByIdQueryHandler(IUOW uow) : base(uow)
        {
        }

        public override async Task<Employee> Handle(GetEmployeesByIdQuery request, CancellationToken cancellationToken)
        {
            return await _uow.EmployeeRepository.GetByIdAsync(request.Id);
        }
    }
}
