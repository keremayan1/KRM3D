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
            services.AddDbContext<MySQLContext>();
            services.AddScoped<IAdultModelViewRepository, AdultModelViewRepository>();
            services.AddScoped<IAdultEducationStatusModelViewRepository, AdultEducationStatusModelViewRepository>();
            services.AddScoped<IAdultGenderModelViewRepository, AdultGenderModelViewRepository>();
            services.AddScoped<IAdultQuestionTitleModelViewRepository, AdultQuestionTitleModelViewRepository>();
            services.AddScoped<IAdultQuestionModelViewRepository, AdultQuestionModelViewRepository>();
            services.AddScoped<IAdultQuestionAnswerModelViewRepository, AdultQuestionAnswerModelViewRepository>();
            services.AddScoped<IAdultFatherModelViewRepository, AdultFatherModelViewRepository>();
            services.AddScoped<IAdultMotherModelViewRepository, AdultMotherModelViewRepository>();
            services.AddScoped<IAdultSiblingsModelViewRepository, AdultSiblingsModelViewRepository>();
            services.AddScoped<IAdultMarriedStatusModelViewRepository, AdultMarriedStatusModelViewRepository>();
            return services;
        }
    }
}
