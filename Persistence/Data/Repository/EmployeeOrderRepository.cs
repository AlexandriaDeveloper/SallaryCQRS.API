using Application.DTOS.EmployeeOrderDeductionBalance;
using Application.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data.Repository
{
    public class EmployeeOrderRepository : Repository<EmployeeOrder>, IEmployeeOrderRepository
    {
        private readonly SallaryCQRSAppContext _context;

        public EmployeeOrderRepository(SallaryCQRSAppContext context, IAuthService authService) : base(context, authService)
        {
            this._context = context;
        }


  

          List<   EmployeeTotalOrderDto> IEmployeeOrderRepository.GetEmployeeSumOrders(int employeeId)
        {


            List< EmployeeTotalOrderDto > employeeTotalOrderDtos
               = new List< EmployeeTotalOrderDto>();
            var result = _context.EmployeeOrders.Include(x => x.EmployeeOrderExecuations)
                .Where(x => x.EmployeeId==employeeId)
                .Include(x => x.Order)
                .GroupBy(x => x.OrderId);


            
            foreach (var item in result)
            {
                EmployeeTotalOrderDto employeeTotalOrderDto= new EmployeeTotalOrderDto();

                employeeTotalOrderDto.OrderId = item.Key;
               

                foreach (EmployeeOrder employeeOrder in item)
                {
                    employeeTotalOrderDto.OrderId=employeeOrder.OrderId;
                   
                   employeeTotalOrderDto.OrderName = employeeOrder.Order.Name;
                   employeeTotalOrderDto.OrderTotal += employeeOrder.EmployeeOrderExecuations.Sum(x => x.Amount);
                }
  

                employeeTotalOrderDtos.Add(employeeTotalOrderDto);

            }


            return employeeTotalOrderDtos;
        }


        public async Task<List<EmployeeOrder>> GetEmployeeOrdersByOrderId(int orderId, int employeeId) { 
        
        
         return await _context.EmployeeOrders.Where(x => x.OrderId==orderId && x.EmployeeId==employeeId).Include(x => x.EmployeeOrderExecuations).ToListAsync();
        }
    }
}
