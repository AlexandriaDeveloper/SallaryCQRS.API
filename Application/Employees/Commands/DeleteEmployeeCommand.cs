using Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Employees.Commands
{
    public record class DeleteEmployeeCommand(Guid id) : IRequest<Unit>;
    public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand, Unit>
    {
        private readonly IUOW _uow;

        public DeleteEmployeeCommandHandler(IUOW uow)
        {
            this._uow = uow;
        }
        public async Task<Unit> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var entity = await _uow.EmployeeRepository.GetByIdAsync(request.id);

            if (entity != null)
            {

                //hello world
                await _uow.EmployeeRepository.Delete(request.id);
                await _uow.SaveChangesAsync(cancellationToken);

            }
            return Unit.Value;
            }
    }
}
