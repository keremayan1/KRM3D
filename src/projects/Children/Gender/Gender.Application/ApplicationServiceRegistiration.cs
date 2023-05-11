using Core.Application.Pipelines.Validation;
using FluentValidation;
using Gender.Application.Features.Genders.Rules;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gender.Application
{
    public static class ApplicationServiceRegistiration
    {
        public static IServiceCollection AddApplicaitonServices(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddAutoMapper(assembly);
            services.AddMediatR(assembly);
           

            services.AddScoped<GenderBusinessRules>();
            services.AddValidatorsFromAssembly(assembly);
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));
            return services;
        }
    }
}
