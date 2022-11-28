using Application.Common;
using Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Employees.Commands { 
    public record class UpdateEmployeeInfoCommand(Guid id, string Name, string TabCode, string TegaraCode, string NationalId) : IRequest<Unit?>;

    public class UpdateEmployeeInfoCommandHandler : Handler<UpdateEmployeeInfoCommand, Unit?>
    {
        public UpdateEmployeeInfoCommandHandler(IUOW uow) : base(uow)
        {
        }

        public override async Task<Unit?> Handle(UpdateEmployeeInfoCommand request, CancellationToken cancellationToken)
        {
            var entity =await _uow.EmployeeRepository.GetByIdAsync(request.id);
            if(entity == null)
            {
                return null;
            }
            if (entity != null)
            {
                entity.Name = request.Name;
                entity.TabCode = request.TabCode;
                entity.TegaraCode=entity.TegaraCode;
                entity.NationalId = request.NationalId;
            }
            await _uow.EmployeeRepository.Update(entity);
            await _uow.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
