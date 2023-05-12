using Application.Features.QuestionTitle.Messages;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.QuestionTitle.Profiles
{
    public class AdultQuestionTitleMapping:Profile
    {
        public AdultQuestionTitleMapping()
        {
            CreateMap<AdultQuestionTitleModelView, CreateAdultQuestionTitleMessage>().ReverseMap();
            CreateMap<AdultQuestionTitleModelView, UpdateAdultQuestionTitleMessage>().ReverseMap();
            CreateMap<AdultQuestionTitleModelView, DeleteAdultQuestionTitleMessage>().ReverseMap();
        }
    }
}
