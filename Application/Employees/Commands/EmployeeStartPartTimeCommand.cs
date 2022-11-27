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
   public record class EmployeeStartPartTimeCommand ( Guid  EmployeeId, DateTime StartPartTime,string? Details) :IRequest<Response<Guid?>>;
    public class EmployeeStartPartTimeCommandHandler : IRequestHandler<EmployeeStartPartTimeCommand, Response<Guid?>>
    {
        private readonly IUOW _uow;

        public EmployeeStartPartTimeCommandHandler(IUOW uow)
        {
            this._uow = uow;
        }

        public async Task<Response<Guid?>> Handle(EmployeeStartPartTimeCommand request, CancellationToken cancellationToken)
        {
            var result = await _uow.EmployeeRepository.EmployeeStartPartTimeDuration(request.EmployeeId, request.StartPartTime, request.Details);

            return result;
        }

     
    }


}
