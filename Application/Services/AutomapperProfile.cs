using Domain.Employees;
using Domain.EmployeeSubscriptions;
using AutoMapper;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();

            CreateMap<EmployeeSubscription,EmployeeSubscriptionDto>().ReverseMap();
        }

       
    }
}
