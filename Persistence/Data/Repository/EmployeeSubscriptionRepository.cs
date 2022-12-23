using Domain.Shared;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data.Repository
{
    public class EmployeeSubscriptionRepository : Repository<EmployeeSubscription>, IEmployeeSubscriptionRepository
    {
        private readonly SallaryCQRSAppContext _context;

        public EmployeeSubscriptionRepository(SallaryCQRSAppContext context, IAuthService authService) : base(context, authService)
        {
            _context = context;
        }

        public async Task<List<EmployeeSubscription>> GetEmployeeSubscriptionBySubscriptionId(int subscriptionId)
       {

            List<EmployeeSubscription> result = new List<EmployeeSubscription>();
             result = await   _context.EmployeeSubscriptions.Where(x => x.IsActive && x.SubscriptionId.Equals(subscriptionId)).ToListAsync();
            return  result;
        
        }
        public async Task<List<EmployeeSubscription>> GetSubscriptionsByEmployeeId(int employeeId)
        {

            List<EmployeeSubscription> result = new List<EmployeeSubscription>();
            result = await _context.EmployeeSubscriptions.Where(x => x.IsActive && x.EmployeeId.Equals(employeeId)).ToListAsync();
            return result;

        }

    }
}
