using Core.Persistance.Repositories.MongoDb.DependencyResolvers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QuestionTitle.Application.Services.Repositories;
using QuestionTitle.Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTitle.Persistance
{
    public static class PersistanceServiceRegistiration
    {
        public static IServiceCollection AddPersistanceServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddMongoDbSettings(configuration);
            services.AddScoped<IQuestionTitleRepository, QuestionTitleRepository>();
            return services;
        }
    }
}
