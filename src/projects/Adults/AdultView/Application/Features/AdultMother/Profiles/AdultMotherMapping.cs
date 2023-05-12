using Application.Features.AdultMother.Messages;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AdultMother.Profiles
{
    public class AdultMotherMapping:Profile
    {
        public AdultMotherMapping()
        {
            CreateMap<AdultMotherModelView, CreateAdultMotherMessage>().ReverseMap();
            CreateMap<AdultMotherModelView, UpdateAdultMotherMessage>().ReverseMap();
            CreateMap<AdultMotherModelView, DeleteAdultMotherMessage>().ReverseMap();
        }
    }
}
