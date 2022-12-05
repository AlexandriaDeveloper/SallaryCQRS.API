using Domain.Constant;
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
        public DbSet<Order> Orders { get; set; }
        public SallaryCQRSAppContext(DbContextOptions<SallaryCQRSAppContext> options):base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasOne(x => x.EmployeeBank).WithOne(t => t.Employee).HasForeignKey<EmployeeBank>(fk => fk.EmployeeId);
            modelBuilder.Entity<Order>().HasData(
                new Order() { Id=Guid.NewGuid(), CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.OrderConstants.ABSENCE },
                new Order() { Id = Guid.NewGuid(), CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.OrderConstants.PUNISHMENT },
                new Order() { Id = Guid.NewGuid(), CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.OrderConstants.VACATION_WITHOT_SALLARY });


            modelBuilder.Entity<Order>().HasData(
                new BudgetItems() { Id = Guid.NewGuid(), CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.BudgetItems.WAZIFI },
                  new BudgetItems() { Id = Guid.NewGuid(), CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.BudgetItems.MOKAMEL },
                  new BudgetItems() { Id = Guid.NewGuid(), CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.BudgetItems.TA3WIDI },
                  new BudgetItems() { Id = Guid.NewGuid(), CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.BudgetItems.GAZAA }
                  



                );

          base.OnModelCreating(modelBuilder);
        }
    }
}
