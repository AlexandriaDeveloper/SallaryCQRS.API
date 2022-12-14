using Application.Common;
using Application.Interfaces;
using Domain.Constant;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Employees.Commands
{
    public record class DeleteEmployeeCommand(int id) : IRequest<Result<Unit>>;
    public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand, Result<Unit>>
    {
        private readonly IUOW _uow;

        public DeleteEmployeeCommandHandler(IUOW uow)
        {
            this._uow = uow;
        }
        public async Task<Result<Unit>> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var entity = await _uow.EmployeeRepository.GetByIdAsync(request.id);
            if (entity == null)
            {

                return Result<Unit>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
                await _uow.EmployeeRepository.Delete(request.id);
              var result =  await _uow.SaveChangesAsync(cancellationToken)>0;
            if(!result)
                return Result<Unit>.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);

            return  Result<Unit>.Success(Unit.Value);
            }
    }
}
