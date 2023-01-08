using MediatR;
using Domain.Models;
using Domain.Interfaces;
using Domain.Shared;
using Application.Common.Messaging;
using AutoMapper;
using Domain.Constants;
namespace Domain.Employees.Queries.GetEmployeeById
{
    public record GetEmployeesByIdQuery(int Id) : IQuery<EmployeeDetailsDto>;

    public class GetEmployeesByIdQueryHandler : IQueryHandler<GetEmployeesByIdQuery, EmployeeDetailsDto>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public GetEmployeesByIdQueryHandler(IUOW uow,IMapper mapper) 
        {
            _uow = uow;
            _mapper = mapper;
        }

        public  async Task<Result<EmployeeDetailsDto>> Handle(GetEmployeesByIdQuery request, CancellationToken cancellationToken)
        {
            var Employee = await _uow.EmployeeRepository.GetByIdAsync(request.Id);
            if (Employee == null)
            {
                return Result<EmployeeDetailsDto>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            var empToReturn = _mapper.Map<EmployeeDetailsDto>(Employee);

            empToReturn.Next =  await _uow.EmployeeRepository.Next(x => x.Id, empToReturn.Id);
            empToReturn.Previous = await _uow.EmployeeRepository.Previous(x => x.Id, empToReturn.Id);
            return Result< EmployeeDetailsDto>.Success(empToReturn);
        }
    }
}
