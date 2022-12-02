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
        public ICollection<EmployeeOrderExecuation> EmployeeOrderExecuations { get; set; }
    }



}
