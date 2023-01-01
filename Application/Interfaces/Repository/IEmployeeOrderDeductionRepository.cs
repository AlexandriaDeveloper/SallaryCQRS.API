using Domain.DTOS.EmployeeOrderDeductionBalance;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Interfaces.Repository
{
    public interface IEmployeeOrderDeductionRepository : IRepository<EmployeeOrderDeduction>
    {

        List<EmployeeTotalOrderDeductionDto> GetEmployeeDeductionOrders(int employeeId);
        Task<List<EmployeeOrderDeduction>> GetEmployeeOrdersDeductionByDeductionId(int orderDeductionId, int employeeId);

    }
}
