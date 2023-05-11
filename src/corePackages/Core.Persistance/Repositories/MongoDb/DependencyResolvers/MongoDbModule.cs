using Core.Persistance.Repositories.MongoDb.Entities;
using Core.Persistance.Repositories.MongoDb.Entities.Concete;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistance.Repositories.MongoDb.DependencyResolvers
{
    public static class MongoDbModule
    {
        public static IServiceCollection AddMongoDbSettings(this IServiceCollection services,IConfiguration configuration)
        {
            services.Configure<MongoDbConnectionSettings>(configuration.GetSection("MongoDbConnectionSettings"));
            return services;
        }
    }
}
