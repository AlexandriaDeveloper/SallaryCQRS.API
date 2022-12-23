using Domain.Shared;
using Domain.Interfaces;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Messaging;

namespace Domain.Employees.Commands.EmployeeEndPartTime
{
    public record class EmployeeEndPartTimeCommand(int PartTimeId, DateTime EndPartTimeDate, string? Details) : ICommand<Unit>;
    public class EmployeeEndPartTimeCommandHandler : ICommandHandler<EmployeeEndPartTimeCommand, Unit>
    {
        private readonly IUOW _uow;

      

        public EmployeeEndPartTimeCommandHandler(IUOW uow) 
        {
            _uow = uow;
        }

        public  async Task<Result<Unit>> Handle(EmployeeEndPartTimeCommand request, CancellationToken cancellationToken)
        {
            //var validation = new EmployeeEndPartTimeCommandValidator();
            //var validate =await validation.ValidateAsync(request, cancellationToken);
            //if (!validate.IsValid) {

            //    return Result<Unit>.Failure(validate.Errors.First().ErrorMessage);
            //}

            EmployeePartTime selectedPartTime = await _uow.EmployeePartTimeRepository.GetByIdAsync(request.PartTimeId);

            if (selectedPartTime == null)
            {

                return Result<Unit>.Failure(new Error("", " عفوا لم يتم العثور على المدة المحددة"));
            }
            selectedPartTime.EndAt = request.EndPartTimeDate;
            if (string.IsNullOrEmpty(request.Details))
                selectedPartTime.Details += "/n" + request.Details;

            await _uow.SaveChangesAsync(cancellationToken);
          
            return Result<Unit>.Success(Unit.Value);
        }

    
    }


}
