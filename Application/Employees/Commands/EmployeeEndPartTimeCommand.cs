using Application.Common;
using Application.Interfaces;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Employees.Commands
{
    public record class EmployeeEndPartTimeCommand(Guid PartTimeId ,DateTime EndPartTimeDate,string? Details) :IRequest<Result<Unit>>;
    public class EmployeeEndPartTimeCommandHandler : Handler<EmployeeEndPartTimeCommand, Result<Unit>>
    {
   

        public EmployeeEndPartTimeCommandHandler(IUOW uow) : base(uow)
        {
        }

        public override async Task<Result<Unit>> Handle  ( EmployeeEndPartTimeCommand request, CancellationToken cancellationToken)
        {
   
            EmployeePartTime selectedPartTime =await _uow.EmployeePartTimeRepository.GetByIdAsync(request.PartTimeId);

            if (selectedPartTime == null)
            {
                
                return Result<Unit>.Failure(" عفوا لم يتم العثور على المدة المحددة");
            }
            selectedPartTime.EndAt = request.EndPartTimeDate;
            if (string.IsNullOrEmpty(request.Details))
                selectedPartTime.Details += "/n" + request.Details;

            await _uow.SaveChangesAsync(cancellationToken);
            return new  Result<Unit>();
        }
    }


}
