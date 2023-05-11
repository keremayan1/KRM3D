using Core.Persistance.Repositories.MongoDb.DependencyResolvers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QuestionAnswer.DataAccess.Abstract;
using QuestionAnswer.DataAccess.Concrete.MongoDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionAnswer.DataAccess
{
    public static class DataAccessServiceRegistiration
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddMongoDbSettings(configuration);
            services.AddScoped<IQuestionAnswerDal, MongoDbQuestionAnswerDal>();
            return services;
        }
    }
}
