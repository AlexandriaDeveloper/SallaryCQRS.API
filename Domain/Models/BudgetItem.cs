using Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class BudgetItem :Entity
    {

        public ICollection<EmployeeOrderExecuation> EmployeeOrderExecuations { get; set; }
    }
}
