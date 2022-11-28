using Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Application.Common;

namespace Application.Employees.Commands
{
    public record class RegisterNewEmployeeCommand (string Name , string TabCode ,string TegaraCode,string NationalId,string? CollageName,string? Section ) :IRequest<Unit>;

    public class RegisterNewEmployeeCommandHandler : Handler<RegisterNewEmployeeCommand, Unit>
    {


        public RegisterNewEmployeeCommandHandler(IUOW uow) :base(uow) 
        {
      
        }
        public override async Task<Unit> Handle(RegisterNewEmployeeCommand request, CancellationToken cancellationToken)
        {

            await _uow.EmployeeRepository.AddItem( new Employee(request.Name,request.NationalId, request.TabCode, request.TegaraCode,request.CollageName,request.Section));

            await _uow.SaveChangesAsync(cancellationToken);
            return await Unit.Task;
        }
    }


}
