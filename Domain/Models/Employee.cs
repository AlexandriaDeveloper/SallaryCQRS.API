using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Employee : Entity
    {
        [MaxLength(14)]
        [Required]
        public string NationalId { get; set; }
        [MaxLength(5)]
        public string TabCode { get; set; }
        [MaxLength(5)]
        public string TegaraCode { get; set; }

        public Employee(string name, string nationalId, string tabCode, string tegaraCode)
        {
            Name = name;
            NationalId = nationalId;
            TabCode = tabCode;
            TegaraCode = tegaraCode;
        }
    }
}
