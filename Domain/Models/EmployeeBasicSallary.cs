﻿using Domain.Primitives;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class EmployeeBasicSallary :Entity {

        [NotMapped]
        public override  string Name { get; set; }
        public int EmployeeId { get; set; }
        public int FinancialYearId { get; set; }
        public decimal? BasicSallary { get; set; }
        public decimal? Wazifi { get; set; }
        public decimal? Mokamel { get; set; }
        public decimal? Ta3widi { get; set; }

        public FinancialYear FinancialYear { get; set; }
        public Employee Employee { get; set; }

        public EmployeeBasicSallary() {}
    }
}
