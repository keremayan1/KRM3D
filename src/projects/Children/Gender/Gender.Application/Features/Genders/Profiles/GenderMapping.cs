using AutoMapper;
using Gender.Application.Features.Genders.Commands.CreateGender;
using Gender.Application.Features.Genders.Commands.DeleteGender;
using Gender.Application.Features.Genders.Commands.UpdateGender;
using Gender.Application.Features.Genders.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using genders = Gender.Domain.Entities;
namespace Gender.Application.Features.Genders.Profiles
{
    public class GenderMapping:Profile
    {
        public GenderMapping()
        {
            //Create
            CreateMap<genders.Gender, CreatedGenderDto>().ReverseMap();
            CreateMap<genders.Gender, CreateGenderCommand>().ReverseMap();
             //Update
            CreateMap<genders.Gender, UpdatedGenderDto>().ReverseMap();
            CreateMap<genders.Gender, UpdateGenderCommand>().ReverseMap();
            //Delete
            CreateMap<genders.Gender, DeletedGenderDto>().ReverseMap();
            CreateMap<genders.Gender, DeleteGenderCommand>().ReverseMap();
        }
    }
}
