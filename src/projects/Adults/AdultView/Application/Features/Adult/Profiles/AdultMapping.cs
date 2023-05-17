using Application.Features.Adult.DTOs;
using Application.Features.Adult.Messages.Adult;
using Application.Features.Adult.Models;
using AutoMapper;
using Core.Persistance.Paging;
using Domain.Entities;
using System.Security.Cryptography.X509Certificates;

namespace Application.Features.Adult.Profiles
{
    public class AdultMapping : Profile
    {
        public AdultMapping()
        {
            CreateMap<AdultModelView, CreateAdultMessage>().ReverseMap();
            CreateMap<AdultModelView, UpdateAdultMessage>().ReverseMap();
            CreateMap<AdultModelView, DeleteAdultMessage>().ReverseMap();

            CreateMap<AdultModelView, GetListAdultDto>().ForMember(x => x.GenderName, opt => opt.MapFrom(x => x.AdultGender.GenderName))
                                                       .ForMember(x => x.EducationStatusName, opt => opt.MapFrom(x => x.EducationStatus.EducationStatusName))
                                                       .ForMember(x => x.AdultMother, opt => opt.MapFrom(x => x.AdultMother))
                                                       .ForMember(x => x.AdultFather, opt => opt.MapFrom(x => x.AdultFather))
                                                       .ForMember(x => x.AdultSiblingsDtos, opt => opt.MapFrom(x => x.AdultSiblings))
                                                       .ForMember(x => x.AdultQuestionAnswerDtos, opt => opt.MapFrom(x => x.AdultQuestionAnswers))
                                                       .ForMember(x=>x.MarriedStatusName,opt=>opt.MapFrom(x=>x.AdultMarriedStatus.MarriedStatusName))
                                                       .ReverseMap();
            CreateMap<IPaginate<AdultModelView>, AdultModel>().ReverseMap();
        }
    }
}
