using Application.DTOS.EmployeeOrderDeductionBalance;
using Domain.Models;
using System.Linq;

namespace Application.Interfaces
{
    public interface IEmployeeOrderRepository : IRepository<EmployeeOrder>
    {
        List<EmployeeTotalOrderDto>  GetEmployeeSumOrders(int employeeId);
        Task<List<EmployeeOrder>> GetEmployeeOrdersByOrderId(int orderId, int employeeId);

    }
}
