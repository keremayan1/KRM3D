using AutoMapper;
using ChildParents.Application.Features.Mothers.DTOs;
using ChildParents.Application.Services.Repositories;
using ChildParents.Domain.Entities;
using Core.Tools.RabbitMQ.Messages.ChildParents.Mothers;
using MassTransit;
using MediatR;

namespace ChildParents.Application.Features.Mothers.Commands.CreatedMothers;

public class CreatedMotherCommandHandler : IRequestHandler<CreateMotherCommand, CreatedMotherDto>
{
    private IMotherRepository _motherRepository;
    private IMapper _mapper;
    private readonly IPublishEndpoint _publishEndpoint;

    public CreatedMotherCommandHandler(IMotherRepository motherRepository, IMapper mapper, IPublishEndpoint publishEndpoint)
    {
        _motherRepository = motherRepository;
        _mapper = mapper;
        _publishEndpoint = publishEndpoint;
    }

    public async Task<CreatedMotherDto> Handle(CreateMotherCommand request, CancellationToken cancellationToken)
    {
        var mappedMother = _mapper.Map<Mother>(request);
        if (request.DoesHaveAMother)
        {
            await _motherRepository.AddAsync(mappedMother);
            var result = _mapper.Map<CreatedMotherDto>(mappedMother);
            await _publishEndpoint.Publish<CreateChildMotherMessage>(mappedMother);
            return result;
        }
        return null;


    }
}

