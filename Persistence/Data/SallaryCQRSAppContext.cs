using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Data
{
    public class SallaryCQRSAppContext :DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public SallaryCQRSAppContext(DbContextOptions<SallaryCQRSAppContext> options):base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
