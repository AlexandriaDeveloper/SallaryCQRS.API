using Domain.Primitives;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class PeriodicSubscription :Entity
    {
        [NotMapped]
        public override string? Name { get => base.Name; set => base.Name = value; }

        public int SubscriptionId { get; set; }

        public int? EmployeeOrderId { get; set; }
        public int? EmployeeOrderDeductionId { get; set; }
        public decimal Amount { get; set; }
        private char creditOrDebit;
        public char CreditOrDebit
        {
            get { return creditOrDebit; }
            set {
                if (EmployeeOrderId.HasValue) 
                    creditOrDebit = 'd';       
                creditOrDebit = 'c';            
            }
        }



        //public Employee Employee { get; set; }
        public EmployeeOrder? EmployeeOrder { get; set; }
        public EmployeeOrderDeduction? EmployeeOrderDeduction { get; set; }
    }
}
