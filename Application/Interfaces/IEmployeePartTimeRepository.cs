using Application.Common;
using Domain.Models;

namespace Application.Interfaces
{
    public interface IEmployeePartTimeRepository : IRepository<EmployeePartTime>
    {

        Task<bool?> IsEmployeeInPartTime(Guid employeeId);
        Task<Result<Guid?>> EmployeeStartPartTime(EmployeePartTime employeePartTime);
        Task<EmployeePartTime?> EmployeeEndPartTime(Guid partTimeId, DateTime endDate);

    }
}
