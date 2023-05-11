using Core.Persistance.Repositories.MongoDb.DependencyResolvers;
using Gender.Application.Services.Repositories;
using Gender.Persistance.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gender.Persistance
{
    public static class PersistanceServiceRegistiration
    {
        public static IServiceCollection AddPersistanceServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddMongoDbSettings(configuration);
            services.AddScoped<IGenderRepository, GenderRepository>();
            return services;
        }
    }
}
