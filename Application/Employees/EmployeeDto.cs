using System.ComponentModel.DataAnnotations;

namespace Application.Employees
{
    public class EmployeeDto
    {

        public int Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        [MaxLength(14)]
        [Required]

        public string NationalId { get; set; }
        [MaxLength(5)]
        public string TabCode { get; set; }
        [MaxLength(5)]
        public string TegaraCode { get; set; }

        [MaxLength(20)]
        public string? CollageName { get; set; }
        [MaxLength(20)]
        public string? Section { get; set; }


        public bool EmployeeHasBank { get => EmployeeBankId.HasValue; }
        public int? EmployeeBankId { get; set; }
    }



}
