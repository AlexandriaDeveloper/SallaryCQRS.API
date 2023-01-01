using MediatR;
using Domain.Models;
using Domain.Interfaces;
using Domain.Shared;
using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
namespace Domain.Employees.Queries.GetEmployeeById
{
    public record GetEmployeesByIdQuery(int Id) : IQuery<EmployeeDto>;

    public class GetEmployeesByIdQueryHandler : IQueryHandler<GetEmployeesByIdQuery, EmployeeDto>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetEmployeesByIdQueryHandler(IUOW uow,IMapper mapper) 
        {
            _uow = uow;
            _mapper = mapper;
        }

        public  async Task<Result<EmployeeDto>> Handle(GetEmployeesByIdQuery request, CancellationToken cancellationToken)
        {
            var Employee = await _uow.EmployeeRepository.GetByIdAsync(request.Id);
            if (Employee == null)
            {
                return Result<EmployeeDto>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            var empToReturn = _mapper.Map<EmployeeDto>(Employee);

            return Result<Employee>.Success(empToReturn);
        }
    }
}
