﻿using Domain.Shared;
using Domain.Interfaces;
using AutoMapper;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Messaging;
using Domain.Constants;
namespace Domain.Employees.Commands.UpdateEmployeeInfo
{
    public record class UpdateEmployeeInfoCommand(EmployeeDto employee) : ICommand<Unit>;

    public class UpdateEmployeeInfoCommandHandler : ICommandHandler<UpdateEmployeeInfoCommand, Unit>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

        public UpdateEmployeeInfoCommandHandler(IUOW uow,IMapper mapper) 
        {
            _uow = uow;
            _mapper = mapper;
        }

        public  async Task<Result<Unit>> Handle(UpdateEmployeeInfoCommand request, CancellationToken cancellationToken)
        {
            var entity = await _uow.EmployeeRepository.GetByIdAsync(request.employee.Id);
            if (entity == null)
            {
                return Result<Unit>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }

            entity = _mapper.Map<EmployeeDto, Employee>(request.employee,entity);
   
            await _uow.EmployeeRepository.Update(entity!);
            var result = await _uow.SaveChangesAsync(cancellationToken) ;
            if (result != Enums.SaveState.Saved)
            {
                return Result<Unit>.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);
            }
            return Result<Unit>.Success(Unit.Value);
        }
    }
}
