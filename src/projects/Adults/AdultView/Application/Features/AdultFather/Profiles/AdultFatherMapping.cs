﻿using Application.Features.AdultFather.DTOs;
using Application.Features.AdultFather.Messages;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AdultFather.Profiles
{
    public class AdultFatherMapping:Profile
    {
        public AdultFatherMapping()
        {
            CreateMap<AdultFatherModelView, CreateAdultFatherMessage>().ReverseMap();
            CreateMap<AdultFatherModelView, UpdateAdultFatherMessage>().ReverseMap();
            CreateMap<AdultFatherModelView, DeleteAdultFatherMessage>().ReverseMap();

            CreateMap<AdultFatherModelView, GetAdultFatherDto>().ForMember(x => x.EducationStatusName, opt => opt.MapFrom(x => x.AdultEducationStatus.EducationStatusName)).ReverseMap();
        }
    }
}
