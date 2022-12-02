using Domain.Primitives;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace Domain.Models
{
    public class EmployeeOrderExecuation  :Entity{
        [NotMapped]
        public override string? Name { get => base.Name; set => base.Name = value; }
        public Guid OrderId{ get; set; }
        public Guid EmployeeId { get; set; }
        public decimal Amount { get; set; }
        public char CreditOrDepit { get; set; }

        public Order Order { get; set; }
        public Employee Employee { get; set; }




    }



}
