using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Mapping.Common.Abstraction;
using Mapping.Common.Concret;
using Microsoft.Extensions.DependencyInjection;

namespace Mapping.Extensions
{
    public static class AutoMapperSlimExtensions
    {
        public static IServiceCollection AddAutoMapperSlimServices(this IServiceCollection services)
        {

            services.AddScoped<IAutoMapperSlim, AutoMapperSlim>();
            return services;
        }
    }
}
