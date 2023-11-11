using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class Extension
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<IAdvertService, AdvertManager>();
            services.AddScoped<IAdvertDal, EfAdvertRepository>();

            services.AddScoped<IAraziAdvService, AraziAdvManager>();
            services.AddScoped<IAraziAdvDal, EfAraziAdvRepository>();

            services.AddScoped<IDetailService, DetailManager>();
            services.AddScoped<IDetailDal, EfDetailRepository>();

            services.AddScoped<IKonutAdvService, KonutAdvManager>();
            services.AddScoped<IKonutAdvDal, EfKonutAdvRepository>();

            services.AddScoped<ITypeeService, TypeeManager>();
            services.AddScoped<ITypeeDal, EfTypeeRepository>();

            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IUserDal, EfUserRepository>();

        }
    }
}
