using AutoMapper;
using Core.Tools.RabbitMQ.Messages.EducationStatus;
using EducationStatuses = Domain.Entities.EducationStatusReadModel;
namespace Application.Features.EducationStatus.Profiles
{
    public class EducationStatusMapping:Profile
    {
        public EducationStatusMapping()
        {
            CreateMap<EducationStatuses, CreateEducationStatusMessage>().ReverseMap();
            CreateMap<EducationStatuses, DeleteEducationStatusMessage>().ReverseMap();
            CreateMap<EducationStatuses, UpdateEducationStatusMessage>().ReverseMap();

        }
    }
}
