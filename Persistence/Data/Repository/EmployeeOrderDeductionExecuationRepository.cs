using Application.Interfaces;
using Domain.Models;

namespace Persistence.Data.Repository
{
    public class EmployeeOrderDeductionExecuationRepository : Repository<EmployeeOrderDeductionExecuation>, IEmployeeOrderDeductionExecuationRepository
    {
        public EmployeeOrderDeductionExecuationRepository(SallaryCQRSAppContext context, IAuthService authService) : base(context, authService)
        {
        }
    }
}
