using BotanikBambu.Repository.Shared.Absract;
using BotanikBambu.Repository.Shared.Concrete;
using BotanikBambu.Business.Abstract;
using BotanikBambu.Business.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimTakip.Business.Configuration
{
    public static class BusinessExtension
    {
        public static void BusinessDI(this IServiceCollection services)
        {
           // services.AddScoped<IUserService, UserService>();
         
        }
        public static void RepositoryDI(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        }
    }
}