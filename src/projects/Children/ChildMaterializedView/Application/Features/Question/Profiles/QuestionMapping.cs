using Application.Features.Question.DTOs;
using Application.Features.Question.Messages;
using AutoMapper;
using Core.Persistance.Paging;
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
