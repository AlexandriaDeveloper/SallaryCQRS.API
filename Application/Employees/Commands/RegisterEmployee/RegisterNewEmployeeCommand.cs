using Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Application.Common;
using Domain.Constant;
using AutoMapper;

namespace Application.Employees.Commands.RegisterEmployee
{
    public record class RegisterNewEmployeeCommand(EmployeeDto employee) : IRequest<Result<Unit>>;

    public class RegisterNewEmployeeCommandHandler : Handler<RegisterNewEmployeeCommand, Result<Unit>>
    {
        private readonly IMapper _mapper;

        public RegisterNewEmployeeCommandHandler(IUOW uow,IMapper mapper) : base(uow)
        {
            _mapper = mapper;
        }
        public override async Task<Result<Unit>> Handle(RegisterNewEmployeeCommand request, CancellationToken cancellationToken)
        {
            RegisterNewEmployeeCommandValidator validator = new RegisterNewEmployeeCommandValidator();
            var validatorResult = await validator.ValidateAsync(request.employee,cancellationToken);
            if (!validatorResult.IsValid) {

                return Result<Unit>.Failure(validatorResult.Errors.First().ErrorMessage);
            }

            Employee emplyeeToDb = _mapper.Map<Employee>(request.employee); 
            await _uow.EmployeeRepository.AddItem(emplyeeToDb);
            var result = await _uow.SaveChangesAsync(cancellationToken) > 0;
            if (!result)
            {

                return Result<Unit>.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);
            };
            return Result<Unit>.Success(Unit.Value);
        }
    }


}
