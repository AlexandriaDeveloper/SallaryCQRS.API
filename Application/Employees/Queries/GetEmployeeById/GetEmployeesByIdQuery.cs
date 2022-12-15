using MediatR;
using Domain.Models;
using Application.Interfaces;
using Application.Common;

namespace Application.Employees.Queries.GetEmployeeById
{
    public record GetEmployeesByIdQuery(int Id) : IRequest<Result<Employee>>;

    public class GetEmployeesByIdQueryHandler : Handler<GetEmployeesByIdQuery, Result<Employee>>
    {
        public GetEmployeesByIdQueryHandler(IUOW uow) : base(uow)
        {
        }

        public override async Task<Result<Employee>> Handle(GetEmployeesByIdQuery request, CancellationToken cancellationToken)
        {
            return Result<Employee>.Success(await _uow.EmployeeRepository.GetByIdAsync(request.Id));
        }
    }
}
