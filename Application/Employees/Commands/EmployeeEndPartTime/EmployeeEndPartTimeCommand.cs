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
using Domain.Constants;
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
          

            EmployeePartTime selectedPartTime = await _uow.EmployeePartTimeRepository.GetByIdAsync(request.PartTimeId);

            if (selectedPartTime == null)
            {

                return Result<Unit>.Failure(new Error("", " عفوا لم يتم العثور على المدة المحددة"));
            }
            selectedPartTime.EndAt = request.EndPartTimeDate;
            if (string.IsNullOrEmpty(request.Details))
                selectedPartTime.Details += "/n" + request.Details;

          var result =   await _uow.SaveChangesAsync(cancellationToken);
            if (result == Enums.SaveState.Exception)
            {
                return Result<Unit>.Failure(Constant.ResultMessages.ErrorMessages.FAIL_WHILE_SAVING_DATA);
            }
          
            return Result<Unit>.Success(Unit.Value);
        }

    
    }


}
