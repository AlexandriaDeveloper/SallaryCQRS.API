using Domain.Employees;
using Domain.EmployeeSubscriptions;
using AutoMapper;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Shared;
using Application.EmployeeBankAccount;

namespace Domain.Services
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<PagedList<Employee>,PagedList<EmployeeDto>>().ReverseMap();
            CreateMap<EmployeeSubscription,EmployeeSubscriptionDto>().ReverseMap();
            CreateMap<Bank, BankDto>().ReverseMap();
            CreateMap<Branch, BrancheDto>().ReverseMap();
        }

       
    }
}
