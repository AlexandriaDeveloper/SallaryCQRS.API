using Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Grade :Entity
    {
        public ICollection<EmployeeGrade> EmployeeGrades { get; set; }
    }
}
