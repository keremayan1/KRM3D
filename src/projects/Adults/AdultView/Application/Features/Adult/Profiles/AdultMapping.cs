using AutoMapper;
using Core.Tools.RabbitMQ.Messages.Adults.Adult;
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
