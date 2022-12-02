using Domain.Primitives;

namespace Domain.Models
{
    public class Branche : Entity
    {
        public Guid BankId { get; set; }

        public Bank Bank { get; set; }

    }
}
