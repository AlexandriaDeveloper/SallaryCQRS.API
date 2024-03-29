﻿using Domain.Shared;
using Domain.Employees.Commands.DeleteEmployee;
using Domain.Interfaces;
using Domain.Services;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public static class ApplicationContainerExtensionMethod 
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
           services.AddAutoMapper(Assembly.GetExecutingAssembly());
           // services.AddTransient<IParam, Param>();
            services.AddMediatR(Assembly.GetExecutingAssembly());
            var assemply = Assembly.GetExecutingAssembly();
            Console.WriteLine("Assemply");
            Console.WriteLine(assemply);
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly(),includeInternalTypes:true);
          
        

            return services;
        }
    }
}
