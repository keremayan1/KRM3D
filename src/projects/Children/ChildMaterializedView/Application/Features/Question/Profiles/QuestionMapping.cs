using Application.Features.Question.DTOs;
using AutoMapper;
using Core.Persistance.Paging;
using Core.Tools.RabbitMQ.Messages.Question;
using Questions = Domain.Entities.Question;
namespace Application.Features.Question.Profiles
{
    public class QuestionMapping:Profile
    {
        public QuestionMapping()
        {
            CreateMap<Questions, CreateQuestionMessage>().ReverseMap();
            CreateMap<Questions, UpdateQuestionMessage>().ReverseMap();
            CreateMap<Questions, DeleteQuestionMessage>().ReverseMap();

           

            
        }
    }
}
