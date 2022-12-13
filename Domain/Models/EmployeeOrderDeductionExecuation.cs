using Domain.Primitives;
using System.ComponentModel.DataAnnotations.Schema;


namespace Domain.Models
{
    public class EmployeeOrderDeductionExecuation : Entity
    {
        [NotMapped]
        public override string? Name { get; set; }
        public int? BudgetItemId { get; set; }
        public int? SubscribtionId { get; set; }
        public decimal Amount { get; set; }
        public int EmployeeOrderDeductionId { get; set; }
        public EmployeeOrderDeduction EmployeeOrderDeduction { get; set; }
        public BudgetItem? BudgetItem { get; set; }
        public Subscription? Subscription { get; set; }




    }


}
