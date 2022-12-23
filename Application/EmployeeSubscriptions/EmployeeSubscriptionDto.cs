using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.EmployeeSubscriptions
{
    public record EmployeeSubscriptionDto(int? Id , int EmployeeId, int SubscriptionId,string? Details,decimal Amount);
   
}
