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

    public record AssignEmployeeBasicSallaryCommand (Guid EmployeeId , Guid FinancialYearId ,decimal BasicSallary,decimal Wazifi,decimal Mokamel, decimal Ta3widi) :IRequest<Guid>;

    public class AssignEmployeeBasicSallaryCommandHandler : Handler<AssignEmployeeBasicSallaryCommand, Guid>
    {
       

        public AssignEmployeeBasicSallaryCommandHandler(IUOW uow):base(uow) 
        {
            
        }
        public override async Task<Guid> Handle(AssignEmployeeBasicSallaryCommand request, CancellationToken cancellationToken)
        {

            EmployeeBasicSallary employeeBasicSallary= new EmployeeBasicSallary() {
            EmployeeId=request.EmployeeId,
            BasicSallary= request.BasicSallary,
            Wazifi= request.Wazifi,
            Mokamel= request.Mokamel,
            Ta3widi= request.Ta3widi,
            FinancialYearId=request.FinancialYearId,
            };
          await  _uow.EmployeeBasicSallaryRepository.AddItem(employeeBasicSallary);
            await _uow.SaveChangesAsync(cancellationToken);
            return employeeBasicSallary.EmployeeId;

        }

       
    }


}
