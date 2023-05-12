using Application.Features.Question.Messages;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Question.Profiles
{
    public class AdultQuestionMapping:Profile
    {
        public AdultQuestionMapping()
        {
            CreateMap<AdultQuestionModelView, CreateAdultQuestionMessage>().ReverseMap();
            CreateMap<AdultQuestionModelView, UpdateAdultQuestionMessage>().ReverseMap();
            CreateMap<AdultQuestionModelView, DeleteAdultQuestionMessage>().ReverseMap();
        }
    }
}
