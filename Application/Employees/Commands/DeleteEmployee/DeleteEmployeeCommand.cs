using Domain.Shared;
using Domain.Interfaces;
using Domain.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Messaging;
using Domain.Primitives;

namespace Domain.Employees.Commands.DeleteEmployee
{
    public record class DeleteEmployeeCommand(int id) : ICommand<Unit>;
    public class DeleteEmployeeCommandHandler : ICommandHandler<DeleteEmployeeCommand, Unit>
    {
        private readonly IUOW _uow;

        public DeleteEmployeeCommandHandler(IUOW uow)
        {
            _uow = uow;
        }
  

       async Task<Result<Unit>> IRequestHandler<DeleteEmployeeCommand, Result<Unit>>.Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var entity = await _uow.EmployeeRepository.GetByIdAsync(request.id);
            if (entity == null)
            {

                return Result<Unit>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            await _uow.EmployeeRepository.Delete(request.id);
            var result = await _uow.SaveChangesAsync(cancellationToken) > 0;
            if (!result)
                return Result<Unit>.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);

            return Result<Unit>.Success(Unit.Value);
        }
    }
}
