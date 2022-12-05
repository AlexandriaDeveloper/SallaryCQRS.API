using Application.Common;
using Application.Interfaces;

using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Persistence.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Data.Repository
{
    public class EmployeePartTimeRepository : Repository<EmployeePartTime>, IEmployeePartTimeRepository
    {
        private readonly SallaryCQRSAppContext _context;
        private readonly IAuthService _authService;

        public EmployeePartTimeRepository(SallaryCQRSAppContext context, IAuthService authService) : base(context, authService)
        {
            this._context = context;
            this._authService = authService;
        }

        public async Task<EmployeePartTime?> EmployeeEndPartTime(Guid partTimeId, DateTime endDate)
        {
            EmployeePartTime? result = await _context.EmployeesPartTimes.FindAsync(partTimeId);
            if (result == null)
            {
                return null;
            }
            result.EndAt = endDate;
            result.ModifiedBy = _authService.GetCurrentLoggedInUser();
            result.ModifiedDate=DateTime.Now;
            return result;
       
        }

        public async Task<Result<Guid?>> EmployeeStartPartTime(EmployeePartTime employeePartTime)
        {
        
            var employee = _context.Employees.Include(x => x.PartTimeDurations).SingleOrDefault(x => x.Id == employeePartTime.EmployeeId);
            if (employee == null)
            {

                return Result<Guid?>.Failure("Employee Not Found"); ;
            }
            if (employee.PartTimeDurations == null)
            {
                employee.PartTimeDurations = new List<EmployeePartTime>();
            }
            if (employee.PartTimeDurations.Any(x => x.IsPartTimeActive))
            {

                return Result<Guid?>.Failure("Employee Alredy In PartTime"); ; 
            }

            EmployeePartTime createdEmployeePartTime = new EmployeePartTime()
            {
                Employee = employee,
                CreatedDate = DateTime.UtcNow,
                CreatedBy = _authService.GetCurrentLoggedInUser(),
                Details = employeePartTime. Details,
                StartFrom =employeePartTime.StartFrom
            };
            employee.PartTimeDurations.Add(createdEmployeePartTime);
            await _context.SaveChangesAsync();
       
            return Result<Guid?>.Success(createdEmployeePartTime.Id);
        }

        public async Task<bool?> IsEmployeeInPartTime(Guid employeeId)
        {
            var result =await  _context.EmployeesPartTimes.Where(x => x.EmployeeId == employeeId).ToListAsync();
            if (result == null) {
                return false;
            }
            if (result.Any(x => x.IsPartTimeActive))
            {

                return true;
            }

        
            return false;

        }
    }
}
