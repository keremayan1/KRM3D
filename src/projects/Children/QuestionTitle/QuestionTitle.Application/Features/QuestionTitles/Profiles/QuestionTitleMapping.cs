using AutoMapper;
using QuestionTitle.Application.Features.QuestionTitles.Commands.CreateQuestionTitle;
using QuestionTitle.Application.Features.QuestionTitles.Commands.DeleteQuestionTitle;
using QuestionTitle.Application.Features.QuestionTitles.Commands.UpdateQuestionTitle;
using QuestionTitle.Application.Features.QuestionTitles.Dtos;
using qt = QuestionTitle.Domain.Entities;
namespace QuestionTitle.Application.Features.QuestionTitles.Profiles
{
    public class QuestionTitleMapping:Profile
    {
        public QuestionTitleMapping()
        {
            CreateMap<qt.QuestionTitle, CreatedQuestionTitleDto>().ReverseMap();
            CreateMap<qt.QuestionTitle, CreateQuestionTitleCommand>().ReverseMap();

            CreateMap<qt.QuestionTitle, UpdatedQuestionTitleDto>().ReverseMap();
            CreateMap<qt.QuestionTitle, UpdateQuestionTitleCommand>().ReverseMap();

            CreateMap<qt.QuestionTitle, DeletedQuestionTitleDto>().ReverseMap();
            CreateMap<qt.QuestionTitle, DeleteQuestionTitleCommand>().ReverseMap();
        }
    }
}
