using Application.DTOS.EmployeeOrderDeductionBalance;
using Application.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data.Repository
{
    public class EmployeeOrderDeductionRepository : Repository<EmployeeOrderDeduction>, IEmployeeOrderDeductionRepository
    {
        private readonly SallaryCQRSAppContext _context;

        public EmployeeOrderDeductionRepository(SallaryCQRSAppContext context, IAuthService authService) : base(context, authService)
        {
            _context = context;
        }
        List<EmployeeTotalOrderDeductionDto> IEmployeeOrderDeductionRepository.GetEmployeeDeductionOrders(int employeeId)
        {


            List<EmployeeTotalOrderDeductionDto> employeeTotalOrderDeductionDtos
               = new List<EmployeeTotalOrderDeductionDto>();
            var result = _context.EmployeeOrderDeductions.Include(x => x.EmployeeOrderDeductionExecuations)
                .Where(x => x.EmployeeId==employeeId)
                .Include(x => x.Order)
                .GroupBy(x => x.OrderId);



            foreach (var item in result)
            {
                EmployeeTotalOrderDeductionDto employeeTotalOrderDeductionDto = new EmployeeTotalOrderDeductionDto();

                employeeTotalOrderDeductionDto.OrderDeductionId = item.Key;


                foreach (EmployeeOrderDeduction employeeOrder in item)
                {

                    employeeTotalOrderDeductionDto.OrderDeductionName = employeeOrder.Order.Name;
                    employeeTotalOrderDeductionDto.Total += employeeOrder.EmployeeOrderDeductionExecuations.Sum(x => x.Amount);
                }


                employeeTotalOrderDeductionDtos.Add(employeeTotalOrderDeductionDto);

            }


            return employeeTotalOrderDeductionDtos;
        }


        public async Task<List<EmployeeOrderDeduction>> GetEmployeeOrdersDeductionByDeductionId(int orderDeductionId, int employeeId)
        {


            return  await _context.EmployeeOrderDeductions.Where(x => x.OrderId == orderDeductionId && x.EmployeeId == employeeId).Include(x => x.EmployeeOrderDeductionExecuations).ToListAsync();
        }
    }
}
