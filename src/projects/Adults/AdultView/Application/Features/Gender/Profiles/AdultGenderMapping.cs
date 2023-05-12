using Application.Features.Gender.Messages;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Gender.Profiles
{
    public class AdultGenderMapping:Profile
    {
        public AdultGenderMapping()
        {
            CreateMap<AdultGenderModelView, CreateAdultGenderMessage>().ReverseMap();
            CreateMap<AdultGenderModelView, UpdateAdultGenderMessage>().ReverseMap();
            CreateMap<AdultGenderModelView, DeleteAdultGenderMessage>().ReverseMap();
        }
    }
}
