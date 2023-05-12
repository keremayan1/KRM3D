using Application.Features.AdultFather.Messages;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AdultFather.Consumers
{
    public class CreateAdultFatherMessageConsumer : IConsumer<CreateAdultFatherMessage>
    {
        private readonly IAdultFatherModelViewRepository _adultFatherModelViewRepository;
        private readonly IMapper _mapper;

        public CreateAdultFatherMessageConsumer(IAdultFatherModelViewRepository adultFatherModelViewRepository, IMapper mapper)
        {
            _adultFatherModelViewRepository = adultFatherModelViewRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<CreateAdultFatherMessage> context)
        {
            var mappedAdultFather = _mapper.Map<AdultFatherModelView>(context.Message);
            await _adultFatherModelViewRepository.AddAsync(mappedAdultFather);
        }
    }
}
