using Domain.Shared;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Messaging;

namespace Domain.Employees.Commands.EmployeeStratPartTime
{
    public record class EmployeeStartPartTimeCommand(int EmployeeId, DateTime StartPartTime, string? Details) : ICommand<int>;
    public class EmployeeStartPartTimeCommandHandler : ICommandHandler<EmployeeStartPartTimeCommand, int>
    {
        private readonly IUOW _uow;

        public EmployeeStartPartTimeCommandHandler(IUOW uow) 
        {
            _uow = uow;
        }

        public  async Task<Result<int>> Handle(EmployeeStartPartTimeCommand request, CancellationToken cancellationToken)
        {
            var result = await _uow.EmployeeRepository.EmployeeStartPartTimeDuration(request.EmployeeId, request.StartPartTime, request.Details);

            return Result.Success( result.Value);
        }


    }


}
