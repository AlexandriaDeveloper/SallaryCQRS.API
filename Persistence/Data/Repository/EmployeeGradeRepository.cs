using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data.Repository
{
    public class EmployeeGradeRepository : Repository<EmployeeGrade>, IEmployeeGradeRepository
    {
        private readonly SallaryCQRSAppContext _context;
        private readonly IAuthService _authService;

        public EmployeeGradeRepository(SallaryCQRSAppContext context, IAuthService authService) : base(context, authService)
        {
            this._context = context;
            this._authService = authService;
        }

        public async Task AssignEmployeeToGrade(int employeeId, int gradeId, DateTime assigningDate) { 
        
            EmployeeGrade employeeGrade =await _context.EmployeeGrades.Where(x => x.EmployeeId==employeeId).OrderByDescending(x => x.CreatedDate).FirstOrDefaultAsync();
            if (employeeGrade != null)
            {
                    employeeGrade.EndAt= assigningDate;
            }
            EmployeeGrade newEmployeeGrade = new EmployeeGrade();
            newEmployeeGrade.StartFrom = assigningDate;
            newEmployeeGrade.EmployeeId= employeeId;
            newEmployeeGrade.GradeId= gradeId;
            newEmployeeGrade.CreatedDate= DateTime.Now;
            newEmployeeGrade.CreatedBy =_authService.GetCurrentLoggedInUser();
            _context.EmployeeGrades.Add(newEmployeeGrade);
        }


        public async Task<EmployeeGrade?> GetEmployeeCurrentGrade(int employeeId)
        {
            var grade=await _context.EmployeeGrades.Where(x => x.EmployeeId == employeeId && x.EndAt == null)
                .Include(t => t.Grade)
                .Include( t=> t.Employees)       
                .OrderByDescending(x => x.CreatedDate).FirstOrDefaultAsync();
            return grade;

        }

        public async Task<List<Employee>> GetEmployeeInSpecificGradeId(int gradeId) {

            var employees = await _context.EmployeeGrades.Where(x => x.GradeId == gradeId && x.EndAt == null)
                    .Include(e => e.Employees)                    
                    .Select(x => x.Employees)                   
                    .ToListAsync();

            return employees;
        }
    }
}
