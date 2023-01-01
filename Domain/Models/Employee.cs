using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Domain.Primitives;

namespace Domain.Models
{
#nullable enable
    public class Employee : Entity
    {
        [MaxLength(14)]
        [Required]

        public string NationalId { get; set; } = "";
        [MaxLength(5)]
        public string? TabCode { get; set; }
        [MaxLength(5)]
        public string? TegaraCode { get; set; }

        [MaxLength(20)]
        public string? CollageName { get; set; }
        [MaxLength(20)]
        public string? Section { get; set; }

        public int? EmployeeBankId { get; set; }
        [NotMapped]
        public bool EmployeeHasBank { get => EmployeeBankId.HasValue; }

        public ICollection<EmployeePartTime>? PartTimeDurations { get; set; }
  
        public ICollection<EmployeeOrder>? EmployeeOrders { get; set; }
        public ICollection<EmployeeSubscription>? EmployeeSubscriptions { get; set; }
        public ICollection<EmployeeGrade>? EmployeeGrades { get; set; }
        public ICollection<PeriodicSubscription>? PeriodicSubscriptions { get; set; }
        public EmployeeBank? EmployeeBank { get; set; }



    
    }
}
