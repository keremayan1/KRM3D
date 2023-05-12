using Application.Features.AdultMother.Messages;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AdultMother.Consumers
{
    public class CreateAdultMotherMessageConsumer : IConsumer<CreateAdultMotherMessage>
    {
        private readonly IAdultMotherModelViewRepository _adultMotherModelViewRepository;
        private readonly IMapper _mapper;

        public CreateAdultMotherMessageConsumer(IAdultMotherModelViewRepository adultMotherModelViewRepository, IMapper mapper)
        {
            _adultMotherModelViewRepository = adultMotherModelViewRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<CreateAdultMotherMessage> context)
        {
            var mappedAdultMother = _mapper.Map<AdultMotherModelView>(context.Message);
            await _adultMotherModelViewRepository.AddAsync(mappedAdultMother);
        }
    }
}
