﻿namespace Domain.EmployeeOrders
{
    public class EmployeeOrderDeductionDto
    {
        public int Id { get; set; }
        public string? Details { get; set; }
        public int OrderId { get; set; }
        public int EmployeeId { get; set; }

        public int? SubscriptionId { get; set; }
        public int FormId { get; set; }
        public decimal Amount { get; set; }
        public char CreditOrDepit { get; set; } = 'c';

    }
}
