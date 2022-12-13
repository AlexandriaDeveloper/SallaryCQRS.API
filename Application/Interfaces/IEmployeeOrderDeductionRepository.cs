using Application.DTOS.EmployeeOrderDeductionBalance;
using Domain.Models;

namespace Application.Interfaces
{
    public interface IEmployeeOrderDeductionRepository : IRepository<EmployeeOrderDeduction>
    {

        List<EmployeeTotalOrderDeductionDto> GetEmployeeDeductionOrders(int employeeId);
        Task<List<EmployeeOrderDeduction>> GetEmployeeOrdersDeductionByDeductionId(int orderDeductionId, int employeeId);

    }
}
