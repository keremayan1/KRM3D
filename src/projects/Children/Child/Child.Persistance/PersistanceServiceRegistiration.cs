using Child.Application.Services.Repositories;
using Child.Persistance.Repositories;
using Core.Persistance.Repositories.MongoDb.DependencyResolvers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Child.Persistance
{
    public static class PersistanceServiceRegistiration
    {
        public static IServiceCollection AddPersistanceServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddMongoDbSettings(configuration);
            services.AddScoped<IChildRepository, ChildRepository>();
            return services;
        }
    }
}
