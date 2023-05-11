using Application;
using Application.Features.ChildFather.Consumers;
using Application.Features.ChildMother.Consumers;
using Application.Features.Children.Consumers;
using Application.Features.ChildSiblings.Consumers;
using Application.Features.EducationStatus.Consumers;
using Application.Features.Gender.Consumers;
using Application.Features.Question.Consumers;
using Application.Features.QuestionAnswer.Consumers;
using Core.Tools.RabbitMQ.Messages.ChildParents.Mothers;
using Core.Tools.RabbitMQ.Messages.QuestionAnswer;
using MassTransit;
using Microsoft.EntityFrameworkCore;
using Persistance;
using Persistance.Contexts;
using RabbitMQ.Client;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMassTransit(x =>
{
    x.AddConsumer<CreateChildMessageConsumer>();
    x.AddConsumer<DeleteChildMessageConsumer>();
    x.AddConsumer<UpdateChildMessageConsumer>();

    x.AddConsumer<CreateChildFatherMessageConsumer>();
    x.AddConsumer<DeleteChildFatherMessageConsumer>();
    x.AddConsumer<UpdateChildFatherMessageConsumer>();

    x.AddConsumer<CreateChildMotherMessageConsumer>();
    x.AddConsumer<DeleteChildMotherMessageConsumer>();
    x.AddConsumer<UpdateChildMotherMessageConsumer>();

    x.AddConsumer<CreateGenderMessageConsumer>();
    x.AddConsumer<UpdateGenderMessageConsumer>();
    x.AddConsumer<DeleteGenderMessageConsumer>();

    x.AddConsumer<CreateQuestionAnswerMessageConsumer>();
    x.AddConsumer<UpdateQuestionAnswerMessageConsumer>();
    x.AddConsumer<DeleteQuestionAnswerMessageConsumer>();

    x.AddConsumer<CreateChildSiblingsMessageConsumer>();
    x.AddConsumer<UpdateChildSiblingsMessageConsumer>();
    x.AddConsumer<DeleteChildSiblingsMessageConsumer>();

    x.AddConsumer<CreateEducationStatusMessageConsumer>();
    x.AddConsumer<DeleteEducationStatusMessageConsumer>();
    x.AddConsumer<UpdateEducationStatusMessageConsumer>();

    x.AddConsumer<CreateQuestionTitleMessageConsumer>();
    x.AddConsumer<UpdateQuestionTitleMessageConsumer>();
    x.AddConsumer<DeleteQuestionTitleMessageConsumer>();

    x.AddConsumer<CreateQuestionMessageConsumer>();
    x.AddConsumer<UpdateQuestionMessageConsumer>();
    x.AddConsumer<DeleteQuestionMessageConsumer>();

    x.UsingRabbitMq((context, config) =>
    {
        config.Host(builder.Configuration["RabbitMQUrl"], "/", host =>
        {
            host.Username("admin");
            host.Password("123456");
        });
        config.UseRawJsonSerializer();
        config.ReceiveEndpoint("create-child-queue", e =>
        {
            
            e.ConfigureConsumer<CreateChildMessageConsumer>(context);
        });
        config.ReceiveEndpoint("delete-child-queue", e =>
        {
            e.ConfigureConsumer<DeleteChildMessageConsumer>(context);
        });
        config.ReceiveEndpoint("update-child-queue", e =>
        {
            e.ConfigureConsumer<UpdateChildMessageConsumer>(context);
        });
        config.ReceiveEndpoint("create-child-father-queue", e =>
        {
            e.ConfigureConsumer<CreateChildFatherMessageConsumer>(context);
        });
        config.ReceiveEndpoint("delete-child-father-queue", e =>
        {
            e.ConfigureConsumer<DeleteChildFatherMessageConsumer>(context);
        });
        config.ReceiveEndpoint("update-child-father-queue", e =>
        {
            e.ConfigureConsumer<UpdateChildFatherMessageConsumer>(context);
        });
        config.ReceiveEndpoint("create-child-mother-queue", e =>
        {
            e.ConfigureConsumer<CreateChildMotherMessageConsumer>(context);
        });
        config.ReceiveEndpoint("update-child-mother-queue", e =>
        {
            e.ConfigureConsumer<UpdateChildMotherMessageConsumer>(context);
        });
        config.ReceiveEndpoint("delete-child-mother-queue", e =>
        {
            e.ConfigureConsumer<DeleteChildMotherMessageConsumer>(context);
        });
        config.ReceiveEndpoint("create-gender-queue", e =>
        {
            e.ConfigureConsumer<CreateGenderMessageConsumer>(context);
        });
        config.ReceiveEndpoint("delete-gender-queue", e =>
        {
            e.ConfigureConsumer<DeleteGenderMessageConsumer>(context);
        });
        config.ReceiveEndpoint("update-gender-queue", e =>
        {
            e.ConfigureConsumer<UpdateGenderMessageConsumer>(context);
        });
        config.ReceiveEndpoint("create-question-answer-queue", e =>
        {
            e.ConfigureConsumer<CreateQuestionAnswerMessageConsumer>(context);
        });
        config.ReceiveEndpoint("delete-question-answer-queue", e =>
        {
            e.ConfigureConsumer<DeleteQuestionAnswerMessageConsumer>(context);
        });
        config.ReceiveEndpoint("update-question-answer-queue", e =>
        {
            e.ConfigureConsumer<UpdateQuestionAnswerMessageConsumer>(context);
        });
        config.ReceiveEndpoint("create-child-siblings-queue", e =>
        {
            e.Bind("createChildSiblings");
            e.ConfigureConsumer<CreateChildSiblingsMessageConsumer>(context);
        });
        config.ReceiveEndpoint("delete-child-siblings-queue", e =>
        {
            e.Bind("deleteChildSiblings");
            e.ConfigureConsumer<DeleteChildSiblingsMessageConsumer>(context);
        });
        config.ReceiveEndpoint("update-child-siblings-queue", e =>
        {
            e.Bind("updateChildSiblings");
            e.ConfigureConsumer<UpdateChildSiblingsMessageConsumer>(context);
        });
        config.ReceiveEndpoint("create-education-status-queue", e =>
        {
            e.Bind("createEducationStatus");
            e.ConfigureConsumer<CreateEducationStatusMessageConsumer>(context);
        });
        config.ReceiveEndpoint("update-education-status-queue", e =>
        {
            e.Bind("updateEducationStatus");
            e.ConfigureConsumer<UpdateEducationStatusMessageConsumer>(context);
        });
        config.ReceiveEndpoint("delete-education-status-queue", e =>
        {
            e.Bind("deleteEducationStatus");
            e.ConfigureConsumer<DeleteEducationStatusMessageConsumer>(context);
        });
        config.ReceiveEndpoint("create-question-title-queue", e =>
        {
            e.ConfigureConsumer<CreateQuestionTitleMessageConsumer>(context);
        });
        config.ReceiveEndpoint("update-question-title-queue", e =>
        {
            e.ConfigureConsumer<UpdateQuestionTitleMessageConsumer>(context);
        });
        config.ReceiveEndpoint("delete-question-title-queue", e =>
        {
            e.ConfigureConsumer<DeleteQuestionTitleMessageConsumer>(context);
        });
        config.ReceiveEndpoint("create-question-queue", e =>
        {
            e.Bind("createQuestion");
            e.ConfigureConsumer<CreateQuestionMessageConsumer>(context);
        });
        config.ReceiveEndpoint("update-question-queue", e =>
        {
            e.Bind("updateQuestion");
            e.ConfigureConsumer<UpdateQuestionMessageConsumer>(context);
        });
        config.ReceiveEndpoint("delete-question-queue", e =>
        {
            e.Bind("deleteQuestion");
            e.ConfigureConsumer<DeleteQuestionMessageConsumer>(context);
        });
    });
});
// Add services to the container.
builder.Services.AddApplicationService();
builder.Services.AddPersistanceServices();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<SQLContext>();
    context.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
