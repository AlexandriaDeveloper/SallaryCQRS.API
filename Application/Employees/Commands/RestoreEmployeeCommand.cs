using Application.Common;
using Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Employees.Commands
{
    public class RestoreEmployeeCommand
    {
        public record class RestorEmployeeCommand(Guid id) : IRequest<Unit>;
        public class RestoreEmployeeCommandHandler : Handler<RestorEmployeeCommand, Unit>
        {
            public RestoreEmployeeCommandHandler(IUOW uow) : base(uow)
            {
            }

            public override async Task<Unit> Handle(RestorEmployeeCommand request, CancellationToken cancellationToken)
            {
                var entity = await _uow.EmployeeRepository.GetByIdAsync( request.id);

                if (entity != null)
                {


                    await _uow.EmployeeRepository.Restore(request.id);
                    await _uow.SaveChangesAsync(cancellationToken);

                }
                return Unit.Value;
            }
        }
    }
}
