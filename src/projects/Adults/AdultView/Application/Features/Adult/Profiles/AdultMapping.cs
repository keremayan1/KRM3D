using Application.Features.Adult.Messages.Adult;
using AutoMapper;

using Domain.Entities;

namespace Application.Features.Adult.Profiles
{
    public class AdultMapping : Profile
    {
        public AdultMapping()
        {
            CreateMap<AdultModelView, CreateAdultMessage>().ReverseMap();
            CreateMap<AdultModelView, UpdateAdultMessage>().ReverseMap();
            CreateMap<AdultModelView, DeleteAdultMessage>().ReverseMap();
        }
    }
}
