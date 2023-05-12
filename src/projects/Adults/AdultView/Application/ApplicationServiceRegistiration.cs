using Application.Features.Adult.Consumers;
using MassTransit;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class ApplicationServiceRegistiration
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddAutoMapper(assembly);
            services.AddMediatR(assembly);
            return services;
        }
        public static IServiceCollection AddRabbitMqWithMassTransit(this IServiceCollection services,IConfiguration configuration)
        {
           services.AddMassTransit(x =>
            {
                x.AddConsumer<CreateAdultMessageConsumer>();
                x.AddConsumer<UpdateAdultMessageConsumer>();
                x.AddConsumer<DeleteAdultMessageConsumer>();

                x.UsingRabbitMq((context, config) =>
                {
                    config.Host(configuration["RabbitMQUrl"], "/", host =>
                    {
                        host.Username("admin");
                        host.Password("123456");
                    });
                    config.UseRawJsonSerializer();
                    config.ReceiveEndpoint("create-adult-queue", e =>
                    {
                        e.Bind("createAdult");
                        e.ConfigureConsumer<CreateAdultMessageConsumer>(context);
                    });
                    config.ReceiveEndpoint("update-adult-queue", e =>
                    {
                        e.Bind("updateAdult");
                        e.ConfigureConsumer<UpdateAdultMessageConsumer>(context);
                    });
                    config.ReceiveEndpoint("delete-adult-queue", e =>
                    {
                        e.Bind("deleteAdult");
                        e.ConfigureConsumer<DeleteAdultMessageConsumer>(context);
                    });
                    
                });
            });
            return services;

        }
    }
}
