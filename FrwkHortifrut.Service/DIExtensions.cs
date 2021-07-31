using FrwkHortifrut.Service.Interface;
using FrwkHortifrut.Service.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace FrwkHortifrut.Service
{
    public static class DIExtensions
    {
        public static void AddService(this IServiceCollection services)
        {
            services.AddTransient<IFrutaService, FrutaService>();
            services.AddTransient<IUserService, UserService>();


        }
    }
}
