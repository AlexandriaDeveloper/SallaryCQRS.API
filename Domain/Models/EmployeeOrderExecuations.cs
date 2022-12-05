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
        public Guid? BudgetItemId { get; set; }
        public decimal Amount { get; set; }
        public int Quantity { get; set; }
        public char CreditOrDepit { get; set; }

        public DateTime? StartFrom { get; set; }
        public DateTime? EndAt { get; set; }

        public Order Order { get; set; }
        public Employee Employee { get; set; }
        public BudgetItem BudgetItem { get; set; }




    }



}
