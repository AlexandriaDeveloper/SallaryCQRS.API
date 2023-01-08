using Domain.Primitives;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class OrderFile :Entity
    {
        [NotMapped]
        public override string Name { get => base.Name; set => base.Name = value; }
        [MaxLength(100)]
        [Required]
        public string Details { get; set; }

        public ICollection<EmployeeOrder> EmployeeOrder { get; set; }
    }
}
