using Application.Features.QuestionAnswer.DTOs;
using AutoMapper;
using Core.Tools.RabbitMQ.Messages.QuestionAnswer;
using System.Security.Cryptography.X509Certificates;
using QuestionAnswers = Domain.Entities.QuestionAnswer;


namespace Application.Features.QuestionAnswer.Profiles
{
    public class QuestionAnswerMapping:Profile
    {
        public QuestionAnswerMapping()
        {
            CreateMap<QuestionAnswers, CreateQuestionAnswerMessage>().ReverseMap();
            CreateMap<QuestionAnswers, DeleteQuestionAnswerMessage>().ReverseMap();
            CreateMap<QuestionAnswers, UpdateQuestionAnswerMessage>().ReverseMap();

            CreateMap<QuestionAnswers, GetQuestionAnswerDto>().ForMember(x=>x.Answer,opt=>opt.MapFrom(x=>x.Answer))
                                                              .ForMember(x=>x.QuestionTitleName,opt=>opt.MapFrom(x=>x.Question.QuestionTitle.QuestionTitleName))
                                                              .ForMember(x => x.QuestionName, opt => opt.MapFrom(x => x.Question.QuestionName))
                                                              .ReverseMap();


        }
    }
}
