using Microsoft.Extensions.DependencyInjection;
using RealEstateApp.Services.Implementations;
using RealEstateApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateApp.Services.DIExtention
{
    public static class ServiceInjection
    {
        public static IServiceCollection AddInjectedServices(this IServiceCollection services)
        {
            services.AddTransient<IPurchaseService, PurchaseService>();
            services.AddTransient<IRentService, RentService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IPictureService, PictureService>();


            return services;
        }
    }
}
