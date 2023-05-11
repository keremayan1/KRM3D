using AutoMapper;
using Core.Tools.RabbitMQ.Messages.Gender;
using g = Domain.Entities;
namespace Application.Features.Gender.Profiles
{
    public class GenderMapping:Profile
    {
        public GenderMapping()
        {
            CreateMap<g.GenderReadModel, CreateGenderMessage>().ReverseMap();
            CreateMap<g.GenderReadModel, DeleteGenderMessage>().ReverseMap();
            CreateMap<g.GenderReadModel, UpdateGenderMessage>().ReverseMap();

        }
    }
}
