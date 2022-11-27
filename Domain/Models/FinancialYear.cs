using Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class FinancialYear :Entity
    {

        public ICollection<EmployeeBasicSallary> EmployeeBasicSallaries { get; set; }
       
    }
}
