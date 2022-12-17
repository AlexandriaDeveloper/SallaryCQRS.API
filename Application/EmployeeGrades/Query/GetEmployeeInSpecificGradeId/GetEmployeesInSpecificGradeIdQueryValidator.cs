using FluentValidation;

namespace Application.EmployeeGrades.Query.GetEmployeeInSpecificGradeId
{
    public class GetEmployeesInSpecificGradeIdQueryValidator : AbstractValidator<GetEmployeesInSpecificGradeIdQuery> {
        public GetEmployeesInSpecificGradeIdQueryValidator()
        {
           
            RuleFor(x => x.gradeId).NotEmpty().NotNull();
        }
    
    }
}
