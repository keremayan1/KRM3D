using Application.Features.ChildFather.DTOs;
using Application.Features.Children.Dtos;
using AutoMapper;
using Core.Tools.RabbitMQ.Messages.ChildParents.Fathers;
using Domain.Entities;
using cf = Domain.Entities;
namespace Application.Features.ChildFather.Profiles
{
    public class ChildFatherMapping:Profile
    {
        public ChildFatherMapping()
        {
            CreateMap<cf.ChildFather, CreateChildFatherMessage>().ReverseMap();
            CreateMap<cf.ChildFather, DeleteChildFatherMessage>().ReverseMap();
            CreateMap<cf.ChildFather, UpdateChildFatherMessage>().ReverseMap();
            CreateMap<cf.ChildFather, GetChildFatherDto>().ForMember(x => x.EducationStatusName, opt => opt.MapFrom(x => x.EducationStatus.EducationStatusName)).ReverseMap();
        }
    }
}
