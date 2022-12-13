using Application.Common;
using Domain.Models;

namespace Application.Interfaces
{
    public interface IEmployeeRepository: IRepository<Employee> {
        Task<Result<int?>> EmployeeStartPartTimeDuration(int employeeId, DateTime startDate, string? details);
        Task  EmployeeEndtPartTimeDuration(int partTimeId, DateTime endDate, string? details);


    }

}
