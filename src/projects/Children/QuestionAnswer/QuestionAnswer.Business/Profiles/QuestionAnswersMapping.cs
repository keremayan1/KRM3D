using AutoMapper;
using QuestionAnswer.Business.DTO;
using qa=QuestionAnswer.Entities.Concrete;


namespace QuestionAnswer.Business.Profiles
{
    public class QuestionAnswersMapping:Profile
    {
        public QuestionAnswersMapping()
        {
            CreateMap<qa.QuestionAnswer, CreatedQuestionAnswerDto>().ReverseMap();
            CreateMap<qa.QuestionAnswer, UpdatedQuestionAnswerDto>().ReverseMap();
            CreateMap<qa.QuestionAnswer, DeletedQuestionAnswerDto>().ReverseMap();
        }
    }
}
