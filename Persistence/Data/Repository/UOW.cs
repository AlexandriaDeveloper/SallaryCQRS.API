using Application.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Data.Repository
{
    internal class UOW : IUOW
    {

        private  IRepository<Employee> _employeeRepository;
        private readonly SallaryCQRSAppContext _context;
        private readonly IAuthService _authService;

        public UOW(SallaryCQRSAppContext context, IAuthService authService)
        {
            this._context = context;
            this._authService = authService;
        }


        public IRepository<Employee> EmployeeRepository => _employeeRepository = _employeeRepository ?? new Repository<Employee> (_context,_authService) ;
        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

      
    }
}
