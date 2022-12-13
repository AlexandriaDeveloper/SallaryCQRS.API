﻿using Domain.Primitives;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class EmployeeOrder :Entity
    {
        [NotMapped]
        public override string? Name { get; set; }
        [MaxLength(200)]
        public string? Details { get; set; }
        public int OrderId { get; set; }
        public int EmployeeId { get; set; }

        public int? Quantity { get; set; }
        public char CreditOrDebit { get; set; }

        public DateTime? StartFrom { get; set; }
        public DateTime? EndAt { get; set; }

        public Order Order{ get; set; }
        public Employee Employee { get; set; }

        public ICollection<EmployeeOrderExecuation> EmployeeOrderExecuations { get; set; }
    }
}