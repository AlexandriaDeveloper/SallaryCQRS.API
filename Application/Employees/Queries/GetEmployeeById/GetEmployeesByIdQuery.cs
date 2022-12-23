using MediatR;
using Domain.Models;
using Domain.Interfaces;
using Domain.Shared;
using Application.Common.Messaging;

namespace Domain.Employees.Queries.GetEmployeeById
{
    public record GetEmployeesByIdQuery(int Id) : IQuery<Employee>;

    public class GetEmployeesByIdQueryHandler : IQueryHandler<GetEmployeesByIdQuery, Employee>
    {
        private readonly IUOW _uow;

        public GetEmployeesByIdQueryHandler(IUOW uow) 
        {
            _uow = uow;
        }

        public  async Task<Result<Employee>> Handle(GetEmployeesByIdQuery request, CancellationToken cancellationToken)
        {
            return Result<Employee>.Success(await _uow.EmployeeRepository.GetByIdAsync(request.Id));
        }
    }
}
