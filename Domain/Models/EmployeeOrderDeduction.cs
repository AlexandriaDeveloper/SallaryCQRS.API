﻿using Domain.Primitives;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class EmployeeOrderDeduction : Entity
    {
        [NotMapped]
        public override string? Name { get; set; }
        [MaxLength(200)]
        public string? Details { get; set; }
        public int OrderId { get; set; }
        public int EmployeeId { get; set; }
        public char CreditOrDebit { get; set; }
        public Order Order { get; set; }
        public Employee Employee { get; set; }

        public ICollection<EmployeeOrderDeductionExecuation> EmployeeOrderDeductionExecuations { get; set; }
    }
}
