using Domain.Primitives;

namespace Domain.Models
{
    public class Bank  :Entity{

        public ICollection<Branche> Branches { get; set; }
    }
}
