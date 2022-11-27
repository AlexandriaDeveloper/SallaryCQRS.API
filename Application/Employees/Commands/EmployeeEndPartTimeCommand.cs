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
    public record class EmployeeEndPartTimeCommand(Guid PartTimeId ,DateTime EndPartTimeDate,string? Details) :IRequest<Response<Unit>>;
    public class EmployeeEndPartTimeCommandHandler : IRequestHandler<EmployeeEndPartTimeCommand, Response<Unit>>
    {
        private readonly IUOW _uow;

        public EmployeeEndPartTimeCommandHandler(IUOW uow)
        {
            this._uow = uow;
        }

       public async Task<Response<Unit>> Handle  ( EmployeeEndPartTimeCommand request, CancellationToken cancellationToken)
        {
            Response<Unit> response = new Response<Unit>();
            EmployeePartTime selectedPartTime =await _uow.EmployeePartTimeRepository.GetByIdAsync(request.PartTimeId);

            if (selectedPartTime == null)
            {
                response.AddError(" عفوا لم يتم العثور على المدة المحددة");
                return response;
            }
            selectedPartTime.EndAt = request.EndPartTimeDate;
            if (string.IsNullOrEmpty(request.Details))
                selectedPartTime.Details += "/n" + request.Details;

            await _uow.SaveChangesAsync(cancellationToken);
            return new  Response<Unit>();
        }
    }


}
