using BotanikBambu.Business.Abstract;
using BotanikBambu.Business.Concrete;
using BotanikBambu.Repository.Shared.Absract;
using BotanikBambu.Repository.Shared.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotanikBambu.Business.Configuration
{
    public static class BusinessExtension
    {
        public static void BusinessDI(this IServiceCollection services)
        {
           // services.AddScoped<IUserService, UserService>();
          services.AddScoped<ICustomerİnfoService,CustomerİnfoService>();
            services.AddScoped<IOrderInfoServices,OrderInfoServices>();
            services.AddScoped<ITruckerInfoServices, TruckerInfoServices>();

        }
        public static void RepositoryDI(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}
