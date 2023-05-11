using Application.Features.ChildSiblings.DTOs;
using AutoMapper;
using Core.Tools.RabbitMQ.Messages.ChildSiblings;
using childSiblings = Domain.Entities.ChildSiblings;

namespace Application.Features.ChildSiblings.Profiles
{
    public class ChildSiblingsMapping:Profile
    {
        public ChildSiblingsMapping()
        {
            CreateMap<childSiblings, CreateChildSiblingsMessage>().ReverseMap();
            CreateMap<childSiblings, UpdateChildSiblingsMessage>().ReverseMap();
            CreateMap<childSiblings, DeleteChildSiblingsMessage>().ReverseMap();

            CreateMap<childSiblings, GetListChildSiblingsDto>().ForMember(x => x.GenderName, opt => opt.MapFrom(x => x.Gender.GenderName))
                                                               .ForMember(x => x.EducationStatusName, opt => opt.MapFrom(x => x.EducationStatus.EducationStatusName))
                                                               .ReverseMap();
        }
    }
}
