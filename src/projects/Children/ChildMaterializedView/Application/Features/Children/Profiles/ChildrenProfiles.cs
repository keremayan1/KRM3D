using Application.Features.ChildFather.DTOs;
using Application.Features.Children.Dtos;
using Application.Features.Children.Models;
using AutoMapper;
using Core.Persistance.Paging;
using Domain.Entities;
using ChildFathers = Domain.Entities.ChildFather;

namespace Application.Features.Children.Profiles
{
    public class ChildrenProfiles:Profile
    {
        public ChildrenProfiles()
        {
            CreateMap<Child, GetListChildDto>().ForMember(x => x.GenderName, opt => opt.MapFrom(x => x.Gender.GenderName))
                                               .ForMember(x=>x.ChildFather,opt=>opt.MapFrom(x=>x.ChildFather))
                                               .ForMember(x=>x.ChildMother,opt=>opt.MapFrom(x=>x.ChildMother))
                                               .ForMember(x=>x.ChildSiblings,opt=>opt.MapFrom(x=>x.ChildSiblings))
                                               .ForMember(x=>x.QuestionAnswers,opt=>opt.MapFrom(x=>x.QuestionAnswers))
                                               
                                               
                                               .ReverseMap();
           

            CreateMap<IPaginate<Child>, ChildModel>().ReverseMap();
            
        }
    }
}
