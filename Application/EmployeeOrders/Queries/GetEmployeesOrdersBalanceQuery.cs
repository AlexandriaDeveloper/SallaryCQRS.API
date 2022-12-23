using Domain.Shared;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.EmployeeOrders.Queries
{
   public record  GetEmployeesOrdersBalance : IRequest< Result<IPagination<EmployeeOrderBalanceDto>>>;
   
}
public class EmployeeOrderBalanceDto {
    public int orderId { get; set; }
    public int EmployeeId { get; set; }
    public string EmployeeName { get; set; }
    public string EmployeeTabCode { get; set; }
    public string EmployeeTegaraCode { get; set; }
    public decimal? CurrentBalance { get; set; }


}