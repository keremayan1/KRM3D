using AutoMapper;
using Core.Tools.RabbitMQ.Messages.Gender;
using Gender.Application.Features.Genders.Dtos;
using Gender.Application.Features.Genders.Rules;
using Gender.Application.Services.Repositories;
using MassTransit;
using MediatR;
using genders = Gender.Domain.Entities;
namespace Gender.Application.Features.Genders.Commands.CreateGender
{
    public class CreateGenderCommand : IRequest<CreatedGenderDto>
    {
        public string GenderName { get; set; }
        public class CreateGenderCommandHandler : IRequestHandler<CreateGenderCommand, CreatedGenderDto>
        {
            private readonly IGenderRepository _genderRepository;
            private readonly IMapper _mapper;
            private readonly GenderBusinessRules _genderBusinessRules;
            private readonly IPublishEndpoint _publishEndpoint;
            public CreateGenderCommandHandler(IGenderRepository genderRepository, IMapper mapper, GenderBusinessRules genderBusinessRules, IPublishEndpoint publishEndpoint)
            {
                _genderRepository = genderRepository;
                _mapper = mapper;
                _genderBusinessRules = genderBusinessRules;
                _publishEndpoint = publishEndpoint;
            }

            public async Task<CreatedGenderDto> Handle(CreateGenderCommand request, CancellationToken cancellationToken)
            {
                var mappedGender = _mapper.Map<genders.Gender>(request);
                
                await _genderBusinessRules.GenderCannotNull(mappedGender);
                await _genderBusinessRules.GenderNameCannotBeDuplicatedWhenInserted(mappedGender.GenderName);

                await _genderRepository.AddAsync(mappedGender);
                await _publishEndpoint.Publish<CreateGenderMessage>(mappedGender);   
                 
                var result = _mapper.Map<CreatedGenderDto>(mappedGender);
                return result;
            }
        }
    }
}
