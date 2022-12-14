﻿using Domain.Constant;
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
        public DbSet<BudgetItem> BudgetItems { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }

        public DbSet<EmployeeOrder> EmployeeOrders { get; set; }
        public DbSet<EmployeeOrderExecuation> EmployeeOrderExecuations { get; set; }
        public DbSet<EmployeeOrderDeduction> EmployeeOrderDeductions { get; set; }

        public SallaryCQRSAppContext(DbContextOptions<SallaryCQRSAppContext> options):base(options) {
    


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         
       
            // TODO : after i do auth system i will chage admin hardcode to one created at db ;
            modelBuilder.Entity<Employee>().HasOne(x => x.EmployeeBank).WithOne(t => t.Employee).HasForeignKey<EmployeeBank>(fk => fk.EmployeeId);
            modelBuilder.Entity <Employee>()
                .HasIndex(x =>x.NationalId).IsUnique();
            modelBuilder.Entity<Employee>()
             .HasIndex(x => x.TabCode).IsUnique();

            modelBuilder.Entity<Order>().HasData(

                //DEBIT
             new Order() {Id=1, CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.OrderConstants.ABSENCE },
             new Order() {Id=2,  CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.OrderConstants.PUNISHMENT_ABSENCE },
             new Order() { Id = 3, CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.OrderConstants.PUNISHMENT_EXAMINATION_REWARD },
             new Order() { Id = 4, CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.OrderConstants.VACATION_WITHOT_SALLARY },


             //Credit
             new Order() { Id = 5, CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.OrderConstants.ABSENCE_DEDUCTION },
             new Order() { Id = 6, CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.OrderConstants.PUNISHMENT_ABSENCE_DEDUCTION },
             new Order() { Id = 7, CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.OrderConstants.PUNISHMENT_EXAMINATION_REWARD_DEDUCTION },
             new Order() { Id = 8, CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.OrderConstants.VACATION_WITHOT_SALLARY_DEDUCTION }




             );


            modelBuilder.Entity<BudgetItem>().HasData(
                new BudgetItem() { Id=1, CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.BudgetItems.WAZIFI },
                new BudgetItem() { Id=2, CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.BudgetItems.MOKAMEL },
                new BudgetItem() {  Id=3, CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.BudgetItems.TA3WIDI },
                new BudgetItem() { Id=4,  CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.BudgetItems.GAZAA },
                new BudgetItem() { Id=5 ,CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.BudgetItems.ABSENCE },
                new BudgetItem() { Id=6,CreatedBy = "Admin", CreatedDate = DateTime.Now, Name = Constant.Model.BudgetItems.SUBSCRIPTIONS }
                );


            modelBuilder.Entity<FinancialYear>().HasData(
                new FinancialYear() { Id = 1, Name = "العام المالى 2017-2018", CreatedBy = "Admin", CreatedDate = DateTime.Now },
                new FinancialYear() { Id = 2, Name = "العام المالى 2018-2019", CreatedBy = "Admin", CreatedDate = DateTime.Now },
                new FinancialYear() { Id = 3, Name = "العام المالى 2020-2019", CreatedBy = "Admin", CreatedDate = DateTime.Now }
                );

            modelBuilder.Entity<Employee>().HasData(
                new Employee() { Id=1 ,Name="محمد على شريف",CollageName="كلية الطب",Section="مكافأة شامله",NationalId="0123456781",TabCode="2309",TegaraCode="1",CreatedBy="Admin",CreatedDate=DateTime.Now},
                new Employee() { Id = 2, Name = "محمود عبد الحميد شاهين", CollageName = "كلية الطب", Section = "مكافأة شامله", NationalId = "0123456782", TabCode = "2310", TegaraCode = "2", CreatedBy = "Admin", CreatedDate = DateTime.Now },
                new Employee() { Id = 3, Name = " اسمهان موسى عيد ", CollageName = "كلية الطب", Section = "مكافأة شامله", NationalId = "0123456783", TabCode = "2311", TegaraCode = "3", CreatedBy = "Admin", CreatedDate = DateTime.Now }

                );


            modelBuilder.Entity<EmployeeBasicSallary>().HasData(
           new EmployeeBasicSallary() { Id = 1,EmployeeId=1,  BasicSallary = 246m, FinancialYearId = 1, Wazifi = 1128.09m, Mokamel = 440m, Ta3widi = 31.17m, CreatedBy = "Admin", CreatedDate = DateTime.Now },
          new EmployeeBasicSallary() { Id = 2,EmployeeId=2,  BasicSallary = 223.5m, FinancialYearId = 1, Wazifi = 1123.49m, Mokamel = 417.5m, Ta3widi = 28.47m, CreatedBy = "Admin", CreatedDate = DateTime.Now },
           new EmployeeBasicSallary() { Id = 3,EmployeeId=3, BasicSallary = 208.5m, FinancialYearId = 1, Wazifi = 1083.65m, Mokamel = 402.3m, Ta3widi = 26.67m, CreatedBy = "Admin", CreatedDate = DateTime.Now }



            );

            modelBuilder.Entity<Subscription>().HasData(
            new Subscription() { Id = 1, Name="تأمين علاجى", CreatedBy = "Admin", CreatedDate = DateTime.Now },
            new Subscription() { Id = 2, Name = "نقابه", CreatedBy = "Admin", CreatedDate = DateTime.Now },
            new Subscription() { Id = 3, Name = "محمول شركة ETI", CreatedBy = "Admin", CreatedDate = DateTime.Now },
            new Subscription() { Id = 4, Name = "محمول شركه سيجنال ", CreatedBy = "Admin", CreatedDate = DateTime.Now },
            new Subscription() { Id = 5, Name = "خزنه تك  ", CreatedBy = "Admin", CreatedDate = DateTime.Now },
            new Subscription() { Id = 6, Name = "نفقه  ", CreatedBy = "Admin", CreatedDate = DateTime.Now }
         

           

     );

  

            base.OnModelCreating(modelBuilder);
        }
    }

   
}
