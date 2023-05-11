using Application.Features.ChildMother.DTOs;
using AutoMapper;
using Core.Tools.RabbitMQ.Messages.ChildParents.Mothers;
using ChildMothers = Domain.Entities.ChildMother;

namespace Application.Features.ChildMother.Profiles
{
    public class ChildMotherMapping:Profile
    {
        public ChildMotherMapping()
        {
            CreateMap<ChildMothers, CreateChildMotherMessage>().ReverseMap();
            CreateMap<ChildMothers, UpdateChildMotherMessage>().ReverseMap();
            CreateMap<ChildMothers, DeleteChildMotherMessage>().ReverseMap();

            CreateMap<ChildMothers, GetChildMotherDto>().ForMember(x => x.EducationStatusName, opt => opt.MapFrom(x => x.EducationStatus.EducationStatusName));
        }
    }
}
