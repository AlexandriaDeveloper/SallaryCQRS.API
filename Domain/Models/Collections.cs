using Domain.Primitives;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Collection :Entity
    {
        public EmployeeCollection CollectionEmployee { get; set; }
    }

    public class EmployeeCollection :Entity
    {
        [NotMapped]
        public override string Name { get => base.Name; set => base.Name = value; }
        public int EmployeeId { get; set; }
        public int CollectionId { get; set; }


        public int? EmployeeOrderInCollection { get; set; }

        public Collection Collection  { get; set; }

        public Employee Employee { get; set; }
    }
}
