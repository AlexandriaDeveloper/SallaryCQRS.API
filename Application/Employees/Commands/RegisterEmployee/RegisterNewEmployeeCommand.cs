﻿using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Domain.Shared;
using AutoMapper;
using Application.Common.Messaging;

namespace Domain.Employees.Commands.RegisterEmployee
{
    public record class RegisterNewEmployeeCommand(EmployeeDto employee) : ICommand<Unit>;

    public class RegisterNewEmployeeCommandHandler : ICommandHandler<RegisterNewEmployeeCommand, Unit>
    {
        private readonly IUOW _uow;
        private readonly IMapper _mapper;

     

        public RegisterNewEmployeeCommandHandler(IUOW uow,IMapper mapper) 
        {
            _uow = uow;
            _mapper = mapper;
        }


       async Task<Result<Unit>> IRequestHandler<RegisterNewEmployeeCommand, Result<Unit>>.Handle(RegisterNewEmployeeCommand request, CancellationToken cancellationToken)
        {
            Employee emplyeeToDb = _mapper.Map<Employee>(request.employee);
            await _uow.EmployeeRepository.AddItem(emplyeeToDb);
            var result = await _uow.SaveChangesAsync(cancellationToken) ;
            if (result != Enums.SaveState.Saved)
            {
                return Result<Unit>.Failure(result);
            };
            return Result<Unit>.Success(Unit.Value);
        }
    }


}
