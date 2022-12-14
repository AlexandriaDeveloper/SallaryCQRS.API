using Application.Common;
using Application.Interfaces;
using AutoMapper;
using Domain.Constant;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Employees.Commands.UpdateEmployeeInfo
{
    public record class UpdateEmployeeInfoCommand(EmployeeDto employee) : IRequest<Result<Unit?>>;

    public class UpdateEmployeeInfoCommandHandler : Handler<UpdateEmployeeInfoCommand, Result<Unit?>>
    {
        private readonly IMapper _mapper;

        public UpdateEmployeeInfoCommandHandler(IUOW uow,IMapper mapper) : base(uow)
        {
            _mapper = mapper;
        }

        public override async Task<Result<Unit?>> Handle(UpdateEmployeeInfoCommand request, CancellationToken cancellationToken)
        {

            var validator = new UpdateEmployeeInfoCommandValidator();
            var validatorResult = await validator.ValidateAsync(request.employee, cancellationToken);
            if (!validatorResult.IsValid) {
                return Result<Unit?>.Failure(validatorResult.Errors.First().ErrorMessage);
            }
            var entity = await _uow.EmployeeRepository.GetByIdAsync(request.employee.Id);
            if (entity == null)
            {
                return Result<Unit?>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }

            entity = _mapper.Map<EmployeeDto, Employee>(request.employee,entity);
   
            await _uow.EmployeeRepository.Update(entity!);
            var result = await _uow.SaveChangesAsync(cancellationToken) > 0;
            if (!result)
            {
                return Result<Unit?>.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);
            }
            return Result<Unit?>.Success(Unit.Value);
        }
    }
}
