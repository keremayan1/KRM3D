using AutoMapper;
using Core.Tools.RabbitMQ.Messages.QuestionTitle;
using QuestionTitles = Domain.Entities.QuestionTitle;


namespace Application.Features.QuestionAnswer.Profiles
{
    public class QuestionTitleMapping:Profile
    {
        public QuestionTitleMapping()
        {
            CreateMap<QuestionTitles, CreateQuestionTitleMessage>().ReverseMap();
            CreateMap<QuestionTitles, DeleteQuestionTitleMessage>().ReverseMap();
            CreateMap<QuestionTitles, UpdateQuestionTitleMessage>().ReverseMap();
        }
    }
}
