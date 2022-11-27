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
        public class RestoreEmployeeCommandHandler : IRequestHandler<RestorEmployeeCommand, Unit>
        {
            private readonly IUOW _uow;

            public RestoreEmployeeCommandHandler(IUOW uow)
            {
                this._uow = uow;
            }
            public async Task<Unit> Handle(RestorEmployeeCommand request, CancellationToken cancellationToken)
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
