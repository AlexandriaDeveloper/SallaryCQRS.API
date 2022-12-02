﻿using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class EmployeeMonthlySubscription {
        public Guid EmployeeId  { get; set; }
        public Guid SubscriptionId{ get; set; }
        [MaxLength(30)]
        public string Month { get; set; }
        public decimal Amount { get; set; }
        public char DepitOrCredit { get; set; }

        public SubscriptionType SubscriptionType { get; set; }
        public int? NumberOfTime { get; set; }

        public Employee Employee { get; set; }
        public Subscription Subscription { get; set; }

    }

    public enum SubscriptionType{ 

        Monthly,
        Once,
        NumbersOfPayment
    }

}
