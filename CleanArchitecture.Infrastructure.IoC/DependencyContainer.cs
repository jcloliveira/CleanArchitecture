using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Application Layer
            services.AddScoped<ICleanArchitectureService, CleanArchitectureService>();

            // Infrastructure.Data Layer
            services.AddScoped<IBaseRepository, BaseRepository>();
            services.AddScoped<ICleanArchitectureRepository, CleanArchitectureRepository>();
        }
    }
}
