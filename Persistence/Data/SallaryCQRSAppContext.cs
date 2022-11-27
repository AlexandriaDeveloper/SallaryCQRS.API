using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Data
{
    public class SallaryCQRSAppContext :DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeePartTime> EmployeesPartTimes { get; set; }

        public DbSet<EmployeeBasicSallary> EmployeeBasicSallaries { get; set; }
        public DbSet<FinancialYear> FinancialYears { get; set; }
        public SallaryCQRSAppContext(DbContextOptions<SallaryCQRSAppContext> options):base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
