using Application.Common;
using Application.Interfaces;
using Domain.Constant;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmployeesSallaries.Commands
{

    public record AssignEmployeeBasicSallaryCommand(Guid EmployeeId, Guid FinancialYearId, decimal BasicSallary, decimal Wazifi, decimal Mokamel, decimal Ta3widi) : IRequest<Result< Guid>>;

    public class AssignEmployeeBasicSallaryCommandHandler : Handler<AssignEmployeeBasicSallaryCommand, Result<Guid>>
    {


        public AssignEmployeeBasicSallaryCommandHandler(IUOW uow) : base(uow)
        {

        }
        public override async Task<Result<Guid>> Handle(AssignEmployeeBasicSallaryCommand request, CancellationToken cancellationToken)
        {

            EmployeeBasicSallary employeeBasicSallary = new EmployeeBasicSallary()
            {
                EmployeeId = request.EmployeeId,
                BasicSallary = request.BasicSallary,
                Wazifi = request.Wazifi,
                Mokamel = request.Mokamel,
                Ta3widi = request.Ta3widi,
                FinancialYearId = request.FinancialYearId,
            };
            await _uow.EmployeeBasicSallaryRepository.AddItem(employeeBasicSallary);
            var result=   await _uow.SaveChangesAsync(cancellationToken)>0;
            if (!result)
                return Result<Guid>.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);
            return Result<Guid>.Success( employeeBasicSallary.EmployeeId);

        }


    }


}
