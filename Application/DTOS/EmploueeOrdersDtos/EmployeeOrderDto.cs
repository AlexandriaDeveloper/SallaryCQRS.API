using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOS.EmploueeOrdersDtos
{
    public class EmployeeOrderDto
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid EmployeeId { get; set; }
        public decimal? Amount { get; set; }
        public int Quantity { get; set; }
        public char CreditOrDepit { get; set; }
    }
}
