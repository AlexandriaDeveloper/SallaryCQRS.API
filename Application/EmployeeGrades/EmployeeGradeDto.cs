using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EmployeeGrades
{
    public class EmployeeGradeDto
    {
        public string EmployeeName { get; set; }
        public string GradeName { get; set; }
        public DateTime? StartFrom { get; set; }
        public DateTime? EndAt { get; set; }
    }
}
