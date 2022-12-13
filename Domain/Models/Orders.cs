using Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Order :Entity
    {
        public ICollection<EmployeeOrder>? EmployeeOrder { get; set; }
        public ICollection<EmployeeOrderDeduction>? EmployeeOrderDeduction { get; set; }
    }



}
