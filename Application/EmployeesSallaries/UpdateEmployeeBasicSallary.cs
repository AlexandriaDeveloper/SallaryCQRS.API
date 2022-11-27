using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmployeesSallaries
{
    public record UpdateEmployeeBasicSallaryCommand(Guid Id, Guid? FinancialYearId , decimal? Wazifi ,decimal? Mokamel ,decimal? Ta3widi ) :IRequest<Unit>;

    public class UpdateEmployeeBasicSallaryCommandHandler : IRequestHandler<UpdateEmployeeBasicSallaryCommand, Unit>
    {
        public Task<Unit> Handle(UpdateEmployeeBasicSallaryCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }


}
