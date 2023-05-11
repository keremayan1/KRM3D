using Application.Services.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Contexts;
using Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance
{
    public static class PersistanceServiceRegistiration
    {
        public static IServiceCollection AddPersistanceServices(this IServiceCollection services)
        {
            services.AddDbContext<SQLContext>();
            services.AddScoped<IChildRepository, ChildRepository>();
            services.AddScoped<IChildSiblingsRepository, ChildSiblingsRepository>();
            services.AddScoped<IChildFatherRepository, ChildFatherRepository>();
            services.AddScoped<IChildMotherRepository, ChildMotherRepository>();
            services.AddScoped<IQuestionRepository, QuestionRepository>();
            services.AddScoped<IQuestionAnswerRepository, QuestionAnswerRepository>();
            services.AddScoped<IQuestionTitleRepository, QuestionTitleRepository>();
            services.AddScoped<IGenderRepository, GenderRepository>();
            services.AddScoped<IEducationStatusRepository,EducationStatusRepository>();
                                   
            return services;
        }
    }
}
