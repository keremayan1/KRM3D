using AutoMapper;
using Child.Application.Features.Children.Dtos;
using Child.Application.Features.Children.Rules;
using Child.Application.Services.Repositories;
using Core.Tools.RabbitMQ.Messages.Child;
using MassTransit;
using MediatR;

using child = Child.Domain.Entities;


namespace Child.Application.Features.Children.Commands.UpdateChild
{
    public  class UpdateChildCommand : IRequest<UpdatedChildDto>
    {
        public string Id { get; set; }
        public string GenderId { get; set; }
        public string NationalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string SchoolName { get; set; }
        public string ClassName { get; set; }
        public class UpdateChildCommandHandler : IRequestHandler<UpdateChildCommand, UpdatedChildDto>
        {
            private readonly IChildRepository _childRepository;
            private readonly IMapper _mapper;
            private readonly ChildBusinessRules _childBusinessRules;
            private readonly IPublishEndpoint _publishEndpoint;
            public UpdateChildCommandHandler(IChildRepository childRepository, IMapper mapper, ChildBusinessRules childBusinessRules, IPublishEndpoint publishEndpoint)
            {
                _childRepository = childRepository;
                _mapper = mapper;
                _childBusinessRules = childBusinessRules;
                _publishEndpoint = publishEndpoint;
            }

            public async Task<UpdatedChildDto> Handle(UpdateChildCommand request, CancellationToken cancellationToken)
            {
                var mappedChild = _mapper.Map<child.Child>(request);

               // await _childBusinessRules.VerifyNationalId(mappedChild);
                _childBusinessRules.ChildPropertiesToUpper(mappedChild);
                _childBusinessRules.ChildPropertiesToUpper(mappedChild);

                await _childRepository.UpdateAsync(mappedChild.Id, mappedChild);
                await _publishEndpoint.Publish<UpdateChildMessage>(new UpdateChildMessage { Id = mappedChild.Id, NationalId = mappedChild.NationalId, FirstName = mappedChild.FirstName, LastName = mappedChild.LastName, ClassName = mappedChild.ClassName, DateOfBirth = mappedChild.DateOfBirth, GenderId = mappedChild.GenderId, SchoolName = mappedChild.SchoolName });
                var result = _mapper.Map<UpdatedChildDto>(mappedChild);
                return result;
            }
        }
    }
}
