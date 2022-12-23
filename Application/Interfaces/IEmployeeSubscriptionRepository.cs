using Domain.Models;

namespace Domain.Interfaces
{
    public interface IEmployeeSubscriptionRepository : IRepository<EmployeeSubscription>
    {
        Task<List<EmployeeSubscription>> GetEmployeeSubscriptionBySubscriptionId(int subscriptionId);
        Task<List<EmployeeSubscription>> GetSubscriptionsByEmployeeId(int employeeId);

    }
}
