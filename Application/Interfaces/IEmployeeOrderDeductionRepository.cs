using Domain.DTOS.EmployeeOrderDeductionBalance;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface IEmployeeOrderDeductionRepository : IRepository<EmployeeOrderDeduction>
    {

        List<EmployeeTotalOrderDeductionDto> GetEmployeeDeductionOrders(int employeeId);
        Task<List<EmployeeOrderDeduction>> GetEmployeeOrdersDeductionByDeductionId(int orderDeductionId, int employeeId);

    }
}
