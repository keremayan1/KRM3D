using AutoMapper;
using ChildParents.Application.Features.Mothers.DTOs;
using ChildParents.Application.Services.Repositories;
using ChildParents.Domain.Entities;
using Core.Tools.RabbitMQ.Messages.ChildParents.Mothers;
using MassTransit;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildParents.Application.Features.Mothers.Commands.UpdatedMothers
{
    public class UpdateMotherCommand : IRequest<UpdatedMotherDto>
    {

        public bool DoesHaveAMother { get; set; }
        public string Id { get; set; }
        public string ChildrenId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EducationStatusId { get; set; }
        public string Job { get; set; }
        public string TelephoneNumber { get; set; }

        public class UpdateMotherCommandHandler : IRequestHandler<UpdateMotherCommand, UpdatedMotherDto>
        {
            private readonly IMotherRepository _motherRepository;
            private readonly IMapper _mapper;
            private readonly IPublishEndpoint _publishEndpoint;

            public UpdateMotherCommandHandler(IMotherRepository motherRepository, IMapper mapper, IPublishEndpoint publishEndpoint)
            {
                _motherRepository = motherRepository;
                _mapper = mapper;
                _publishEndpoint = publishEndpoint;
            }

            public async Task<UpdatedMotherDto> Handle(UpdateMotherCommand request, CancellationToken cancellationToken)
            {
                var mappedMothers = _mapper.Map<Mother>(request);
                await _motherRepository.UpdateAsync(mappedMothers.Id, mappedMothers);
                await _publishEndpoint.Publish<UpdateChildMotherMessage>(mappedMothers);
                var result = _mapper.Map<UpdatedMotherDto>(mappedMothers);
                return result;
            }
        }
    }
}
