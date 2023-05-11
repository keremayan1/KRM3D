using AutoMapper;
using Core.Tools.RabbitMQ.Messages.Gender;
using Gender.Application.Features.Genders.Dtos;
using Gender.Application.Features.Genders.Rules;
using Gender.Application.Services.Repositories;
using MassTransit;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using genders = Gender.Domain.Entities;
namespace Gender.Application.Features.Genders.Commands.UpdateGender
{
    public partial class UpdateGenderCommand:IRequest<UpdatedGenderDto>
    {
        public string Id { get; set; }
        public string GenderName { get; set; }
        public class UpdateGenderCommandHandler : IRequestHandler<UpdateGenderCommand, UpdatedGenderDto>
        {
            private readonly IGenderRepository _genderRepository;
            private readonly IMapper _mapper;
            private readonly GenderBusinessRules _genderBusinessRules;
            private readonly IPublishEndpoint _publishEndpoint;
            public UpdateGenderCommandHandler(IGenderRepository genderRepository, IMapper mapper, GenderBusinessRules genderBusinessRules, IPublishEndpoint publishEndpoint)
            {
                _genderRepository = genderRepository;
                _mapper = mapper;
                _genderBusinessRules = genderBusinessRules;
                _publishEndpoint = publishEndpoint;
            }

            public async Task<UpdatedGenderDto> Handle(UpdateGenderCommand request, CancellationToken cancellationToken)
            {
                var mappedGender = _mapper.Map<genders.Gender>(request);
                
              
                await _genderBusinessRules.GenderNameCannotBeDuplicatedWhenUpdated(mappedGender.GenderName);

                await _genderRepository.UpdateAsync(mappedGender.Id,mappedGender);
                await _publishEndpoint.Publish<UpdateGenderMessage>(mappedGender);
                var result = _mapper.Map<UpdatedGenderDto>(mappedGender);
                return result;

            }
        }
    }
}
