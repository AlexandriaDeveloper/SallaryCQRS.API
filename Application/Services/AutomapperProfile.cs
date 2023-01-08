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
using Application.OrderFiles;
using Application.FinancialYears;
using Application.Orders;

namespace Domain.Services
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<FinancialYear, FinancialYearDto>().ReverseMap();
            CreateMap<OrderFile, OrderFileDto>().ReverseMap();
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<PagedList< OrderFile>, PagedList<OrderFileDto>>().ReverseMap();
            CreateMap<Employee, EmployeeDetailsDto>().ReverseMap();
            CreateMap<PagedList<Employee>,PagedList<EmployeeDto>>().ReverseMap();
            CreateMap<EmployeeSubscription,EmployeeSubscriptionDto>().ReverseMap();
            CreateMap<Bank, BankDto>().ReverseMap();
            CreateMap<Branch, BrancheDto>().ReverseMap();
        }

       
    }
}
