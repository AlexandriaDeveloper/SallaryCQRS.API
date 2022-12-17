using Application.Common;
using Application.Interfaces;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class ApplicationContainerExtensionMethod 
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
           services.AddAutoMapper(Assembly.GetExecutingAssembly());
           // services.AddTransient<IParam, Param>();
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
