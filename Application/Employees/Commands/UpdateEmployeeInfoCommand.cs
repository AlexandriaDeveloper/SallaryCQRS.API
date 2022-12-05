using Application.Common;
using Application.Interfaces;
using Domain.Constant;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Employees.Commands { 
    public record class UpdateEmployeeInfoCommand(Guid id, string Name, string TabCode, string TegaraCode, string NationalId) : IRequest <Result<Unit?>>;

    public class UpdateEmployeeInfoCommandHandler : Handler<UpdateEmployeeInfoCommand, Result<Unit?>>
    {
        public UpdateEmployeeInfoCommandHandler(IUOW uow) : base(uow)
        {
        }

        public override async Task<Result<Unit?>> Handle(UpdateEmployeeInfoCommand request, CancellationToken cancellationToken)
        {
            var entity =await _uow.EmployeeRepository.GetByIdAsync(request.id);
            if(entity == null)
            {
                return Result<Unit?>.Failure(Constant.ResultMessages.ErrorMessages.ENTITY_NOT_EXIST);
            }
            if (entity != null)
            {
                entity.Name = request.Name;
                entity.TabCode = request.TabCode;
                entity.TegaraCode=entity.TegaraCode;
                entity.NationalId = request.NationalId;
            }
            await _uow.EmployeeRepository.Update(entity!);
           var result =  await _uow.SaveChangesAsync(cancellationToken)>0;
            if (!result) {
                return Result<Unit?>.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);
            }
            return  Result<Unit?>.Success(Unit.Value);
        }
    }
}
