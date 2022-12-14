﻿using Domain.Primitives;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class EmployeeBank :Entity {


        [NotMapped]
        public override string Name { get; set; }
        public int BranchId { get; set; }
        public int EmployeeId{ get; set; }
        [MaxLength(22)]
        public string? AccountNumber { get; set; }
        public required Branche Branche { get; set; }
        public required Employee Employee { get; set; }

    }
}
