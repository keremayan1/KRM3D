using Application.Features.QuestionAnswer.Messages;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.QuestionAnswer.Profiles
{
    public class AdultQuestionAnswerMapping:Profile
    {
        public AdultQuestionAnswerMapping()
        {
            CreateMap<AdultQuestionAnswerModelView, CreateAdultQuestionAnswerMessage>().ReverseMap();
            CreateMap<AdultQuestionAnswerModelView, UpdateAdultQuestionAnswerMessage>().ReverseMap();
            CreateMap<AdultQuestionAnswerModelView, DeleteAdultQuestionAnswerMessage>().ReverseMap();

        }
    }
}
