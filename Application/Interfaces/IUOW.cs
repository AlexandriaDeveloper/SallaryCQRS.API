using Domain;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUOW:IDisposable
    {
        IEmployeeRepository EmployeeRepository { get; }
        IEmployeeBasicSallaryRepository EmployeeBasicSallaryRepository { get; }
        IRepository<EmployeePartTime> EmployeePartTimeRepository { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
