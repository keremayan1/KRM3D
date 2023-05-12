using Application.Features.Adult.Messages.Adult;
using Application.Services.Repositories;
using AutoMapper;

using Domain.Entities;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Adult.Consumers
{
    public class CreateAdultMessageConsumer : IConsumer<CreateAdultMessage>
    {
        private readonly IAdultModelViewRepository _adultModelViewRepository;
        private readonly IMapper _mapper;

        public CreateAdultMessageConsumer(IAdultModelViewRepository adultModelViewRepository, IMapper mapper)
        {
            _adultModelViewRepository = adultModelViewRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<CreateAdultMessage> context)
        {
            var mappedAdult = _mapper.Map<AdultModelView>(context.Message);
            await _adultModelViewRepository.AddAsync(mappedAdult);
        }
    }
}
