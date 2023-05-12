using Application.Features.EducationStatus.Messages;
using AutoMapper;
using Domain.Entities;

namespace Application.Features.EducationStatus.Profiles
{
    public class EducationStatusMapping:Profile
    {
        public EducationStatusMapping()
        {
            CreateMap<AdultEducationStatusModelView, CreateEducationStatusMessage>().ReverseMap();
            CreateMap<AdultEducationStatusModelView, UpdateEducationStatusMessage>().ReverseMap();
            CreateMap<AdultEducationStatusModelView, DeleteEducationStatusMessage>().ReverseMap();
        }
    }
}
