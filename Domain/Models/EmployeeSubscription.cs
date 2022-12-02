using Domain.Primitives;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class EmployeeSubscription :Entity {

        [NotMapped]
        public override string? Name { get => base.Name; set => base.Name = value; }
        public Guid EmployeeId { get; set; }
        public Guid SubscriptionId { get; set; }
        public decimal Amount { get; set; }

        public Employee Employee { get; set; }
        public Subscription Subscription{ get; set; }

    }



}
