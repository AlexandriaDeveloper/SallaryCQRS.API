using Application.Common;
using Application.Interfaces;
using Domain.Constant;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Employees.Commands.RestoreEmployee
{

        public record class RestorEmployeeCommand(int id) : IRequest<Result<Unit>>;
        public class RestoreEmployeeCommandHandler : Handler<RestorEmployeeCommand, Result<Unit>>
        {
            public RestoreEmployeeCommandHandler(IUOW uow) : base(uow)
            {
            }

            public override async Task<Result<Unit>> Handle(RestorEmployeeCommand request, CancellationToken cancellationToken)
            {

            var validation = new RestorEmployeeCommandValidator();
            var validator =await validation.ValidateAsync(request, cancellationToken);
            if (!validator.IsValid) {
                return Result<Unit>.Failure(validator.Errors.First().ErrorMessage);
            }
                var entity = await _uow.EmployeeRepository.GetByIdAsync(request.id);
                if (entity == null)
                {
                    return Result<Unit>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
                }
                if (entity != null)
                {


                    await _uow.EmployeeRepository.Restore(request.id);
                    var result = await _uow.SaveChangesAsync(cancellationToken) > 0;
                    if (!result)
                    {
                        return Result<Unit>.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);
                    }

                }
                return Result<Unit>.Success(Unit.Value);
            }
        }
    
}
