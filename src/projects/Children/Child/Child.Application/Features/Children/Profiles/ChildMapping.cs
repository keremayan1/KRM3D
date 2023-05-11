using AutoMapper;
using Child.Application.Features.Children.Commands.CreateChild;
using Child.Application.Features.Children.Commands.DeleteChild;
using Child.Application.Features.Children.Commands.UpdateChild;
using Child.Application.Features.Children.Dtos;
using child = Child.Domain.Entities;
namespace Child.Application.Features.Children.Profiles
{
    public class ChildMapping:Profile
    {
        public ChildMapping()
        {
            //Create
            CreateMap<child.Child, CreatedChildDto>().ReverseMap();
            CreateMap<child.Child, CreateChildCommand>().ReverseMap();
            //Update
            CreateMap<child.Child, UpdatedChildDto>().ReverseMap();
            CreateMap<child.Child, UpdateChildCommand>().ReverseMap();
            //Delete
            CreateMap<child.Child, DeletedChildDto>().ReverseMap();
            CreateMap<child.Child, DeleteChildCommand>().ReverseMap();
        }
    }
}
