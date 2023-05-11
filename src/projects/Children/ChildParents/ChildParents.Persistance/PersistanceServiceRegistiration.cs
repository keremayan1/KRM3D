using ChildParents.Application.Services.Repositories;
using ChildParents.Persistance.Repositories;
using Core.Persistance.Repositories.MongoDb.DependencyResolvers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildParents.Persistance
{
    public static class PersistanceServiceRegistiration
    {
        public static IServiceCollection AddPersistanceServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddMongoDbSettings(configuration);
            services.AddScoped<IMotherRepository, MotherRepository>();
            services.AddScoped<IFatherRepository, FatherRepository>();
            return services;
        }
    }
}
