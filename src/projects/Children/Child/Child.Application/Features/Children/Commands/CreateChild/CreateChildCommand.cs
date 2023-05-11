using AutoMapper;
using Child.Application.Features.Children.Dtos;
using Child.Application.Features.Children.Rules;
using Child.Application.Services.Repositories;
using Core.Tools.RabbitMQ.Messages.Child;
using MassTransit;
using MediatR;
using child = Child.Domain.Entities;
namespace Child.Application.Features.Children.Commands.CreateChild
{
    public class CreateChildCommand:IRequest<CreatedChildDto>
    {
        public string GenderId { get; set; }
        public string NationalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string SchoolName { get; set; }
        public string ClassName { get; set; }

        public class CreateChildCommandHandler : IRequestHandler<CreateChildCommand, CreatedChildDto>
        {
            private readonly IChildRepository _childRepository;
            private readonly IMapper _mapper;
            private readonly ChildBusinessRules _childBusinessRules;
            private readonly IPublishEndpoint _publishEndpoint;
            public CreateChildCommandHandler(IChildRepository childRepository, IMapper mapper, ChildBusinessRules childBusinessRules, IPublishEndpoint publishEndpoint)
            {
                _childRepository = childRepository;
                _mapper = mapper;
                _childBusinessRules = childBusinessRules;
                _publishEndpoint = publishEndpoint;
            }

            public async Task<CreatedChildDto> Handle(CreateChildCommand request, CancellationToken cancellationToken)
            {
                var mappedChild = _mapper.Map<child.Child>(request);
               
              // await _childBusinessRules.VerifyNationalId(mappedChild);
                //_childBusinessRules.CheckIfNationalIdExists(mappedChild.NationalId);
                _childBusinessRules.ChildPropertiesToUpper(mappedChild);
                _childBusinessRules.ChildPropertiesTrim(mappedChild);

                await _childRepository.AddAsync(mappedChild);
                await _publishEndpoint.Publish<CreateChildMessage>(new CreateChildMessage { Id = mappedChild.Id, FirstName = mappedChild.FirstName, LastName = mappedChild.LastName, ClassName = mappedChild.ClassName, DateOfBirth = mappedChild.DateOfBirth, GenderId = mappedChild.GenderId, NationalId = mappedChild.NationalId, SchoolName = mappedChild.SchoolName });

                var result = _mapper.Map<CreatedChildDto>(mappedChild);
                return result;
            }
        }
    }
}
