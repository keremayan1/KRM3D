using Application.Features.MarriedStatus.Messages;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.MarriedStatus.Profiles
{
    public class AdultMarriedStatusMapping:Profile
    {
        public AdultMarriedStatusMapping()
        {
            CreateMap<AdultMarriedStatusModelView, CreateAdultMarriedStatusMessage>().ReverseMap();
            CreateMap<AdultMarriedStatusModelView, UpdateAdultMarriedStatusMessage>().ReverseMap();
            CreateMap<AdultMarriedStatusModelView, DeleteAdultMarriedStatusMessage>().ReverseMap();
        }
    }
}
