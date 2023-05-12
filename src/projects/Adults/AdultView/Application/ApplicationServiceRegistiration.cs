using Application.Features.Adult.Consumers;
using Application.Features.AdultFather.Consumers;
using Application.Features.AdultMother.Consumers;
using Application.Features.AdultSiblings.Consumers;
using Application.Features.EducationStatus.Consumers;
using Application.Features.Gender.Consumers;
using Application.Features.Question.Consumers;
using Application.Features.QuestionAnswer.Consumers;
using Application.Features.QuestionTitle.Consumers;
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
                //Adult
                x.AddConsumer<CreateAdultMessageConsumer>();
                x.AddConsumer<UpdateAdultMessageConsumer>();
                x.AddConsumer<DeleteAdultMessageConsumer>();

                //EducationStatus
                x.AddConsumer<CreateEducationStatusMessageConsumer>();
                x.AddConsumer<UpdateEducationStatusMessageConsumer>();
                x.AddConsumer<DeleteEducationStatusMessageConsumer>();

                //AdultGender
                x.AddConsumer<CreateAdultGenderMessageConsumer>();
                x.AddConsumer<UpdateAdultGenderMessageConsumer>();
                x.AddConsumer<DeleteAdultGenderMessageConsumer>();

                //AdultQuestionTitle
                x.AddConsumer<CreateAdultQuestionTitleMessageConsumer>();
                x.AddConsumer<UpdateAdultQuestionTitleMessageConsumer>(); 
                x.AddConsumer<DeleteAdultQuestionTitleMessageConsumer>();

                //AdultQuestion
                x.AddConsumer<CreateAdultQuestionMessageConsumer>();
                x.AddConsumer<UpdateAdultQuestionMessageConsumer>();
                x.AddConsumer<DeleteAdultQuestionMessageConsumer>();

                //AdultQuestionAnswer
                x.AddConsumer<CreateAdultQuestionAnswerMessageConsumer>();
                x.AddConsumer<UpdateAdultQuestionAnswerMessageConsumer>();
                x.AddConsumer<DeleteAdultQuestionAnswerMessageConsumer>();

                //AdultFather
                x.AddConsumer<CreateAdultFatherMessageConsumer>();
                x.AddConsumer<UpdateAdultFatherMessageConsumer>();
                x.AddConsumer<DeleteAdultFatherMessageConsumer>();

                //AdultMother
                x.AddConsumer<CreateAdultMotherMessageConsumer>();
                x.AddConsumer<UpdateAdultMotherMessageConsumer>();
                x.AddConsumer<DeleteAdultMotherMessageConsumer>();

                //AdultSiblings
                x.AddConsumer<CreateAdultSiblingsMessageConsumer>();
                x.AddConsumer<UpdateAdultSiblingsMessageConsumer>();
                x.AddConsumer<DeleteAdultSiblingsMessageConsumer>();

                x.UsingRabbitMq((context, config) =>
                {
                    config.Host(configuration["RabbitMQUrl"], "/", host =>
                    {
                        host.Username("admin");
                        host.Password("123456");
                    });
                    config.UseRawJsonSerializer();
                    
                    //Adult
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

                    //EducationStatus
                    config.ReceiveEndpoint("create-adult-education-status-queue", e =>
                    {
                        e.Bind("createEducationStatus");
                        e.ConfigureConsumer<CreateEducationStatusMessageConsumer>(context);
                    });
                    config.ReceiveEndpoint("update-adult-education-status-queue", e =>
                    {
                        e.Bind("updateEducationStatus");
                        e.ConfigureConsumer<UpdateEducationStatusMessageConsumer>(context);
                    });
                    config.ReceiveEndpoint("delete-adult-education-status-queue", e =>
                    {
                        e.Bind("deleteEducationStatus");
                        e.ConfigureConsumer<DeleteEducationStatusMessageConsumer>(context);
                    });

                    //AdultGender
                    config.ReceiveEndpoint("create-adult-gender-queue", e =>
                    {
                       
                        e.ConfigureConsumer<CreateAdultGenderMessageConsumer>(context);
                    });
                    config.ReceiveEndpoint("update-adult-gender-queue", e =>
                    {
                       
                        e.ConfigureConsumer<UpdateAdultGenderMessageConsumer>(context);
                    });
                    config.ReceiveEndpoint("delete-adult-gender-queue", e =>
                    {
                        e.ConfigureConsumer<DeleteAdultGenderMessageConsumer>(context);
                    });

                    //AdultQuestionTitle
                    config.ReceiveEndpoint("create-adult-question-title-queue", e =>
                    {
                        e.Bind("createAdultQuestionTitle");
                        e.ConfigureConsumer<CreateAdultQuestionTitleMessageConsumer>(context);
                    });
                    config.ReceiveEndpoint("update-adult-question-title-queue", e =>
                    {
                        e.Bind("updateAdultQuestionTitle");
                        e.ConfigureConsumer<UpdateAdultQuestionTitleMessageConsumer>(context);
                    });
                    config.ReceiveEndpoint("delete-adult-question-title-queue", e =>
                    {
                        e.Bind("deleteAdultQuestionTitle");
                        e.ConfigureConsumer<DeleteAdultQuestionTitleMessageConsumer>(context);
                    });

                    //AdultQuestion
                    config.ReceiveEndpoint("create-adult-question-queue", e =>
                    {
                        e.Bind("createAdultQuestion");
                        e.ConfigureConsumer<CreateAdultQuestionMessageConsumer>(context);
                    });
                    config.ReceiveEndpoint("update-adult-question-queue", e =>
                    {
                        e.Bind("updateAdultQuestion");
                        e.ConfigureConsumer<UpdateAdultQuestionMessageConsumer>(context);
                    });
                    config.ReceiveEndpoint("delete-adult-question-queue", e =>
                    {
                        e.Bind("deleteAdultQuestion");
                        e.ConfigureConsumer<DeleteAdultQuestionMessageConsumer>(context);
                    });

                    //AdultQuestionAnswer
                    config.ReceiveEndpoint("create-adult-question-answer-queue", e =>
                    {
                        e.Bind("createAdultQuestionAnswer");
                        e.ConfigureConsumer<CreateAdultQuestionAnswerMessageConsumer>(context);
                    });
                    config.ReceiveEndpoint("update-adult-question-answer-queue", e =>
                    {
                        e.Bind("updateAdultQuestionAnswer");
                        e.ConfigureConsumer<UpdateAdultQuestionAnswerMessageConsumer>(context);
                    });
                    config.ReceiveEndpoint("delete-adult-question-answer-queue", e =>
                    {
                        e.Bind("deleteAdultQuestionAnswer");
                        e.ConfigureConsumer<DeleteAdultQuestionAnswerMessageConsumer>(context);
                    });

                    //AdultFather
                    config.ReceiveEndpoint("create-adult-father-queue", e =>
                    {
                        e.Bind("createAdultFamilyFather");
                        e.ConfigureConsumer<CreateAdultFatherMessageConsumer>(context);
                    });
                    config.ReceiveEndpoint("update-adult-father-queue", e =>
                    {
                        e.Bind("updateAdultFamilyFather");
                        e.ConfigureConsumer<UpdateAdultFatherMessageConsumer>(context);
                    });
                    config.ReceiveEndpoint("delete-adult-father-queue", e =>
                    {
                        e.Bind("deleteAdultFamilyFather");
                        e.ConfigureConsumer<DeleteAdultFatherMessageConsumer>(context);
                    });

                    //AdultMother
                    config.ReceiveEndpoint("create-adult-mother-queue", e =>
                    {
                        e.Bind("createAdultFamilyMother");
                        e.ConfigureConsumer<CreateAdultMotherMessageConsumer>(context);
                    });
                    config.ReceiveEndpoint("update-adult-mother-queue", e =>
                    {
                        e.Bind("updateAdultFamilyMother");
                        e.ConfigureConsumer<UpdateAdultMotherMessageConsumer>(context);
                    });
                    config.ReceiveEndpoint("delete-adult-mother-queue", e =>
                    {
                        e.Bind("deleteAdultFamilyMother");
                        e.ConfigureConsumer<DeleteAdultMotherMessageConsumer>(context);
                    });
                    //AdultSiblings
                    config.ReceiveEndpoint("create-adult-siblings-queue", e =>
                    {
                        e.Bind("createAdultFamilySiblings");
                        e.ConfigureConsumer<CreateAdultSiblingsMessageConsumer>(context);
                    });
                    config.ReceiveEndpoint("update-adult-siblings-queue", e =>
                    {
                        e.Bind("updateAdultFamilySiblings");
                        e.ConfigureConsumer<UpdateAdultSiblingsMessageConsumer>(context);
                    });
                    config.ReceiveEndpoint("delete-adult-siblings-queue", e =>
                    {
                        e.Bind("deleteAdultFamilySiblings");
                        e.ConfigureConsumer<DeleteAdultSiblingsMessageConsumer>(context);
                    });
                });
            });
            return services;

        }
    }
}
