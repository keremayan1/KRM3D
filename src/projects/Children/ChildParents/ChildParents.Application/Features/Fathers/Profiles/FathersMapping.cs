using AutoMapper;
using ChildParents.Application.Features.Fathers.Commands.CreateFathers;
using ChildParents.Application.Features.Fathers.Commands.DeleteFathers;
using ChildParents.Application.Features.Fathers.Commands.UpdateFathers;
using ChildParents.Application.Features.Fathers.DTOs;
using ChildParents.Application.Features.Mothers.DTOs;
using ChildParents.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildParents.Application.Features.Fathers.Profiles
{
    public class FathersMapping : Profile
    {
        public FathersMapping()
        {
            CreateMap<Father, CreatedFatherDto>().ReverseMap();
            CreateMap<Father, CreateFathersCommand>().ReverseMap();

            CreateMap<Father, UpdatedFatherDto>().ReverseMap();
            CreateMap<Father, UpdateFathersCommand>().ReverseMap();

            CreateMap<Father,DeletedFathersDto>().ReverseMap();
            CreateMap<Father, DeleteFatherCommand>().ReverseMap();
        }
    }
}
