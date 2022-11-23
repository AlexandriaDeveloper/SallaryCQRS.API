using MediatR;
using Domain.Models;
using Application.Interfaces;

namespace Application.Queries
{
    public record GetEmployeesByIdQuery(Guid Id) : IRequest<Employee>;

    public class GetEmployeesByIdQueryHandler : IRequestHandler<GetEmployeesByIdQuery, Employee>
    {
        private readonly IUOW _uow;

        public GetEmployeesByIdQueryHandler(IUOW UOW)
        {
            _uow = UOW;
        }
        public async Task<Employee> Handle(GetEmployeesByIdQuery request, CancellationToken cancellationToken)
        {
            return await _uow.EmployeeRepository.GetByIdAsync(request.Id);
        }
    }
}
