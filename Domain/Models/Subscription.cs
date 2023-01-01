using Domain.Primitives;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Subscription :Entity {

       
        public ICollection<EmployeeSubscription> EmployeeSubscriptions { get; set; }

    }


}
