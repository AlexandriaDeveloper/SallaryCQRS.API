using Application.Common;
using Application.Interfaces;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmployeesSallaries
{
    public record UpdateEmployeeBasicSallaryCommand(Guid Id, Guid? FinancialYearId ,decimal?BasicSallary, decimal? Wazifi ,decimal? Mokamel ,decimal? Ta3widi ) :IRequest<Unit?>;

    public class UpdateEmployeeBasicSallaryCommandHandler : Handler<UpdateEmployeeBasicSallaryCommand, Unit?>
    {
        public UpdateEmployeeBasicSallaryCommandHandler(IUOW uow) : base(uow)
        {
        }

        public override async Task<Unit?> Handle(UpdateEmployeeBasicSallaryCommand request, CancellationToken cancellationToken)
        {
            EmployeeBasicSallary currentEmployeeSallaryData =await _uow.EmployeeBasicSallaryRepository.GetByIdAsync(request.Id);
            if (currentEmployeeSallaryData == null) {
                return null;
            }
            if (request.FinancialYearId.HasValue) { 
                currentEmployeeSallaryData.FinancialYearId=request.FinancialYearId.Value;
            }
            if (request.BasicSallary.HasValue)
            {
                currentEmployeeSallaryData.BasicSallary = request.BasicSallary.Value;
            }
            if (request.Wazifi.HasValue)
            {
                currentEmployeeSallaryData.Wazifi = request.Wazifi.Value;
            }
            if (request.Mokamel.HasValue)
            {
                currentEmployeeSallaryData.Mokamel = request.Mokamel.Value;
            }
            if (request.Ta3widi.HasValue)
            {
                currentEmployeeSallaryData.Ta3widi = request.Ta3widi.Value;
            }
            await _uow.EmployeeBasicSallaryRepository.Update(currentEmployeeSallaryData);
            await _uow.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }


}
