using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOS.EmployeeOrderDeductionBalance
{
    public class EmployeeOrderDeductionBalanceDto
    {

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string TabCode { get; set; }
        public string TegaraCode { get; set; }
        public string NationalId { get; set; }

        public List<EmployeeTotalOrderDto>? EmploueeOrdersDtos { get; set; }
        public EmployeeOrderDeductionBalanceDto()
        {
            if (EmploueeOrdersDtos == null) { 
            EmploueeOrdersDtos= new List<EmployeeTotalOrderDto>();
            }
        }
    }

    public class EmployeeTotalOrderDto{
        public int OrderId { get; set; }
  
        public string OrderName { get; set; }
        public string OrderDeductionName { get; set; }
        public decimal OrderTotal { get; set; } = 0;

        public decimal DeductionTotal { get; set; } = 0;
        public decimal Net {get => OrderTotal-DeductionTotal;  }


    }

    public class EmployeeTotalOrderDeductionDto
    {
        public int OrderDeductionId { get; set; }
        public string OrderDeductionName { get; set; }
        public decimal Total { get; set; }


    }
}
