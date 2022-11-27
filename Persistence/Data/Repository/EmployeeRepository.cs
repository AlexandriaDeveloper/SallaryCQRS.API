using Application.Common;
using Application.Interfaces;
using Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Data.Repository
{
    public class EmployeeRepository :Repository<Employee>,IEmployeeRepository
    {
        private readonly SallaryCQRSAppContext _context;
        private readonly IAuthService _authService;

        public EmployeeRepository(SallaryCQRSAppContext context,IAuthService authService) : base(context,authService)
        {
            this._context = context;
            this._authService = authService;
        }


        public async Task<Response<Guid?>> EmployeeStartPartTimeDuration(Guid employeeId, DateTime startDate, string? details) {

            Response<Guid?> response = new Response<Guid?>();

            var employee = _context.Employees.Include(x => x.PartTimeDurations).SingleOrDefault(x => x.Id == employeeId);
            if (employee == null)
            {
                response.AddError("Employee Not Found");
                return response;
            }
            if(employee.PartTimeDurations== null) { 
                employee.PartTimeDurations= new List<EmployeePartTime>();
            }
            if (employee.PartTimeDurations.Any(x => x.IsPartTimeActive)) {
                 response.AddError("Employee Alredy In PartTime");
                return response; ;
            }

            EmployeePartTime createdEmployeePartTime = new EmployeePartTime()
            {
                Employee = employee,
                CreatedDate = DateTime.UtcNow,
                CreatedBy = _authService.GetCurrentLoggedInUser(),
                Details = details,
                StartFrom = startDate
            };
            employee.PartTimeDurations.Add(createdEmployeePartTime);
            await _context.SaveChangesAsync();
            response.Result = createdEmployeePartTime.Id;
            return response;
        }


        public async Task EmployeeEndtPartTimeDuration(Guid partTimeId, DateTime endDate, string? details)
        {

            var existPartTime=await _context.EmployeesPartTimes.FindAsync(partTimeId);
            if (existPartTime==null) {
                throw new Exception("Not Found");
            }

            existPartTime.EndAt = endDate;

            if (string.IsNullOrEmpty( details)) {
                existPartTime.Details= details;
            }

            existPartTime.ModifiedBy= _authService.GetCurrentLoggedInUser();
            existPartTime.ModifiedDate= DateTime.UtcNow;


            _context.EmployeesPartTimes.Update(existPartTime);
            await _context.SaveChangesAsync();
        }
    }
}
//YL2PXXTJPB