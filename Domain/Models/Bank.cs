using Domain.Primitives;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Bank  :Entity{

        public ICollection<Branch>? Branches { get; set; }
    }
}
