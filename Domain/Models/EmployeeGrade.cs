using Domain.Primitives;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    public class EmployeeGrade : Entity {
        [NotMapped]
        public override string? Name { get => base.Name; set => base.Name = value; }
        public int EmployeeId { get; set; }
        public int GradeId { get; set; }
        public DateTime StartFrom { get; set; }
        public DateTime? EndAt { get; set; }

        public Grade Grade { get; set; }
        public Employee Employees { get; set; }

    }
}
