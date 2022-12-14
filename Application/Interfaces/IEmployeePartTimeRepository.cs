using Application.Common;
using Domain.Models;

namespace Application.Interfaces
{
    public interface IEmployeePartTimeRepository : IRepository<EmployeePartTime>
    {

        Task<bool?> IsEmployeeInPartTime(int employeeId);
        Task<Result<int?>> EmployeeStartPartTime(EmployeePartTime employeePartTime);
        Task<EmployeePartTime?> EmployeeEndPartTime(int partTimeId, DateTime endDate);

    }
}
