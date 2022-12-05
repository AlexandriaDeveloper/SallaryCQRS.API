using Application.Common;
using Domain.Models;

namespace Application.Interfaces
{
    public interface IEmployeeRepository: IRepository<Employee> {
        Task<Result<Guid?>> EmployeeStartPartTimeDuration(Guid employeeId, DateTime startDate, string? details);
        Task  EmployeeEndtPartTimeDuration(Guid partTimeId, DateTime endDate, string? details);


    }

}
