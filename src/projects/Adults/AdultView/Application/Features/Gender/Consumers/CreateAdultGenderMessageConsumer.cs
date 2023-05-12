using Application.Features.Gender.Messages;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Gender.Consumers
{
    public class CreateAdultGenderMessageConsumer : IConsumer<CreateAdultGenderMessage>
    {
        private readonly IAdultGenderModelViewRepository _adultGenderModelViewRepository;
        private readonly IMapper _mapper;

        public CreateAdultGenderMessageConsumer(IAdultGenderModelViewRepository adultGenderModelViewRepository, IMapper mapper)
        {
            _adultGenderModelViewRepository = adultGenderModelViewRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<CreateAdultGenderMessage> context)
        {
            var mappedAdultGender = _mapper.Map<AdultGenderModelView>(context.Message);
            await _adultGenderModelViewRepository.AddAsync(mappedAdultGender);
        }
    }
}
