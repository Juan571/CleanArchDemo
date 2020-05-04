using ArchLimpio.Application.Interfaces;
using ArchLimpio.Application.Services;
using ArchLimpio.Domain.Interfaces;
using ArchLimpio.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArchLimpio.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer 
            services.AddScoped<ICourseService, CouserService>();

            //Infra.Data layer
            services.AddScoped<ICourseRepository, CourseRepository>();

        }
    }
}
