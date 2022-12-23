using Domain.Shared;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface IEmployeePartTimeRepository : IRepository<EmployeePartTime>
    {

        Task<bool?> IsEmployeeInPartTime(int employeeId);
        Task<Result<int>> EmployeeStartPartTime(EmployeePartTime employeePartTime);
        Task<EmployeePartTime?> EmployeeEndPartTime(int partTimeId, DateTime endDate);

    }
}
