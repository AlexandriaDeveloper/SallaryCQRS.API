using Domain.Shared;
using Domain.Models;
using Domain.Interfaces;

namespace Application.Interfaces.Repository
{
    public interface IEmployeePartTimeRepository : IRepository<EmployeePartTime>
    {

        Task<bool?> IsEmployeeInPartTime(int employeeId);
        Task<Result<int>> EmployeeStartPartTime(EmployeePartTime employeePartTime);
        Task<EmployeePartTime> EmployeeEndPartTime(int partTimeId, DateTime endDate);

    }
}
