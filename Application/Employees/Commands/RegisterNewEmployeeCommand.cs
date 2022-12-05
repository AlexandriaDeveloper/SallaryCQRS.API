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

namespace Application.Employees.Commands
{
    public record class RegisterNewEmployeeCommand (string Name , string TabCode ,string TegaraCode,string NationalId,string? CollageName,string? Section ) :IRequest <Result<Unit>>;

    public class RegisterNewEmployeeCommandHandler : Handler<RegisterNewEmployeeCommand, Result<Unit>>
    {


        public RegisterNewEmployeeCommandHandler(IUOW uow) :base(uow) 
        {
      
        }
        public override async Task<Result<Unit>> Handle(RegisterNewEmployeeCommand request, CancellationToken cancellationToken)
        {

            await _uow.EmployeeRepository.AddItem( new Employee(request.Name,request.NationalId, request.TabCode, request.TegaraCode,request.CollageName,request.Section));
            var result = await _uow.SaveChangesAsync(cancellationToken)>0;
            if (!result) {

                return Result<Unit>.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);
            };
            return Result<Unit>.Success(Unit.Value);
        }
    }


}
