using Microsoft.Extensions.DependencyInjection;
using QuestionAnswer.Business.Abstracts;
using QuestionAnswer.Business.Concretes;
using QuestionAnswer.Business.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace QuestionAnswer.Business
{
    public static class BusinessServiceRegistiration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddAutoMapper(assembly);
            services.AddScoped<QuestionAnswerBusinessRules>();
            services.AddScoped<IQuestionAnswerService, QuestionAnswerManager>();
            return services;
        }
    }
}
