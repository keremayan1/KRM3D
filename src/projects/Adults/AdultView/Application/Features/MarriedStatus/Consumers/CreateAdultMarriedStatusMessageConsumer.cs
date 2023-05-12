using Application.Features.MarriedStatus.Messages;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.MarriedStatus.Consumers
{
    public class CreateAdultMarriedStatusMessageConsumer : IConsumer<CreateAdultMarriedStatusMessage>
    {
        private readonly IAdultMarriedStatusModelViewRepository _adultMarriedStatusModelViewRepository;
        private readonly IMapper _mapper;

        public CreateAdultMarriedStatusMessageConsumer(IAdultMarriedStatusModelViewRepository adultMarriedStatusModelViewRepository, IMapper mapper)
        {
            _adultMarriedStatusModelViewRepository = adultMarriedStatusModelViewRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<CreateAdultMarriedStatusMessage> context)
        {
            var mappedAdultMarriedStatus = _mapper.Map<AdultMarriedStatusModelView>(context.Message);
            await _adultMarriedStatusModelViewRepository.AddAsync(mappedAdultMarriedStatus);
        }
    }
}
