﻿using Application.Features.AdultSiblings.Messages;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AdultSiblings.Profiles
{
    public class AdultSiblingsMapping:Profile
    {
        public AdultSiblingsMapping()
        {
            CreateMap<AdultSiblingsModelView, CreateAdultSiblingsMessage>().ReverseMap();
            CreateMap<AdultSiblingsModelView, UpdateAdultSiblingsMessage>().ReverseMap();
            CreateMap<AdultSiblingsModelView, DeleteAdultSiblingsMessage>().ReverseMap();

        }
    }
}
