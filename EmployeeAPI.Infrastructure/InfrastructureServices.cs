using EmployeeAPI.Domain.IRepository;
using EmployeeAPI.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAPI.Infrastructure
{
    public static class InfrastructureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddTransient<IEmployeeRepository,EmployeeRepository>();
            return services;
        }
    }
}
