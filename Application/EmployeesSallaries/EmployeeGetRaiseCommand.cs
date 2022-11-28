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
    public record EmployeeGetRaisedCommand(Guid lasyEmployeeSallaryId
            , Guid newFinancialYear,
            decimal? wazifiPercentage,
            decimal? wazifiAmount,
            decimal? wazifiMinAmount,
            decimal? wazifiMaxAmount,
            decimal? mokamelPercentage,
            decimal? mokamelAmount,
            decimal? mokamelMinAmount,
            decimal? mokamelMaxAmount

        ) :IRequest<EmployeeBasicSallary>;
    public class EmployeeGetRaisedCommandHandler : Handler<EmployeeGetRaisedCommand, EmployeeBasicSallary>
    {
        public EmployeeGetRaisedCommandHandler(IUOW uow) : base(uow)
        {
        }

        public override async Task<EmployeeBasicSallary> Handle(EmployeeGetRaisedCommand request, CancellationToken cancellationToken)
        {
           var result= await _uow.EmployeeBasicSallaryRepository.EmployeeGetRaise(request.lasyEmployeeSallaryId,
                request.newFinancialYear,
                request.wazifiPercentage,
                request.wazifiAmount,
                request.wazifiMinAmount,
                request.wazifiMaxAmount,
                request.mokamelPercentage, request.mokamelAmount, request.mokamelMinAmount, request.mokamelMaxAmount);
            return result;
        }
    }
}
