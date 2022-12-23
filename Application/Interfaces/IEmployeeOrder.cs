using Domain.DTOS.EmployeeOrderDeductionBalance;
using Domain.Models;
using System.Linq;

namespace Domain.Interfaces
{
    public interface IEmployeeOrderRepository : IRepository<EmployeeOrder>
    {
        List<EmployeeTotalOrderDto>  GetEmployeeSumOrders(int employeeId);
        Task<List<EmployeeOrder>> GetEmployeeOrdersByOrderId(int orderId, int employeeId);

    }
}
