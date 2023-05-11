using AutoMapper;
using ChildParents.Application.Features.Mothers.Commands.CreatedMothers;
using ChildParents.Application.Features.Mothers.Commands.DeletedMothers;
using ChildParents.Application.Features.Mothers.Commands.UpdatedMothers;
using ChildParents.Application.Features.Mothers.DTOs;
using ChildParents.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildParents.Application.Features.Mothers.Models
{
    public class MothersMapping:Profile
    {
        public MothersMapping()
        {
            CreateMap<Mother, CreatedMotherDto>().ReverseMap();
            CreateMap<Mother, CreateMotherCommand>().ReverseMap();

            CreateMap<Mother,DeletedMotherDto>().ReverseMap();
            CreateMap<Mother, DeleteMothersCommand>().ReverseMap();

            CreateMap<Mother, UpdatedMotherDto>().ReverseMap();
            CreateMap<Mother, UpdateMotherCommand>().ReverseMap();
        }
    }
}
