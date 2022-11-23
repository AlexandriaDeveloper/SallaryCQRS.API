using Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Application.Commands
{
    public record class RegisterNewEmployeeCommand (string Name , string TabCode ,string TegaraCode,string NationalId) :IRequest<Unit>;

    public class RegisterNewEmployeeCommandHandler : IRequestHandler<RegisterNewEmployeeCommand, Unit>
    {
        private readonly IUOW _uow;

        public RegisterNewEmployeeCommandHandler(IUOW uow)
        {
            this._uow = uow;
        }
        public async Task<Unit> Handle(RegisterNewEmployeeCommand request, CancellationToken cancellationToken)
        {

            await _uow.EmployeeRepository.AddItem(new Employee(request.Name,request.NationalId, request.TabCode, request.TegaraCode));

            await _uow.SaveChangesAsync();
            return await Unit.Task;
        }
    }


}
