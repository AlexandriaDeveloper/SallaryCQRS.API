using Application.Common;
using Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Employees.Commands
{
   public record class EmployeeStartPartTimeCommand ( int  EmployeeId, DateTime StartPartTime,string? Details) :IRequest<Result<int?>>;
    public class EmployeeStartPartTimeCommandHandler : Handler<EmployeeStartPartTimeCommand, Result<int?>>
    {
        public EmployeeStartPartTimeCommandHandler(IUOW uow) : base(uow)
        {
        }

        public override async Task<Result<int?>> Handle(EmployeeStartPartTimeCommand request, CancellationToken cancellationToken)
        {
            var result = await _uow.EmployeeRepository.EmployeeStartPartTimeDuration(request.EmployeeId, request.StartPartTime, request.Details);

            return result;
        }

      
    }


}
