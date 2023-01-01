using Domain.Shared;
using Domain.Models;
using Domain.Interfaces;

namespace Application.Interfaces.Repository
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Task<Result<int>> EmployeeStartPartTimeDuration(int employeeId, DateTime startDate, string details);
        Task EmployeeEndtPartTimeDuration(int partTimeId, DateTime endDate, string details);
        Task EmployeeAddBankAccount(int employeeId, EmployeeBank employeeBank);
        Task EmployeeRemoveBankAccount(Employee employee);

    }

}
