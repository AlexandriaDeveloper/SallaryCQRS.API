using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Services
{
    public class AuthService : IAuthService
    {
        public string GetCurrentLoggedInUser()
        {
            return "Test";
        }

        public bool IsLoggedIn() { return true; }
    }
}
