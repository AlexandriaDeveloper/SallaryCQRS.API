using Domain.Models;

namespace Domain.Interfaces
{
    public interface IEmployeeGradeRepository : IRepository<EmployeeGrade>
    {

        Task<EmployeeGrade?> GetEmployeeCurrentGrade(int employeeId);
        Task AssignEmployeeToGrade(int employeeId, int gradeId, DateTime assigningDate);
        Task<List<Employee>> GetEmployeeInSpecificGradeId(int gradeId);
    }
}
