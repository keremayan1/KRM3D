using Application.Features.AdultSiblings.Messages;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AdultSiblings.Consumers
{
    public class CreateAdultSiblingsMessageConsumer : IConsumer<CreateAdultSiblingsMessage>
    {
        private readonly IAdultSiblingsModelViewRepository _adultSiblingsModelViewRepository;
        private readonly IMapper _mapper;

        public CreateAdultSiblingsMessageConsumer(IAdultSiblingsModelViewRepository adultSiblingsModelViewRepository, IMapper mapper)
        {
            _adultSiblingsModelViewRepository = adultSiblingsModelViewRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<CreateAdultSiblingsMessage> context)
        {
            var mappedAdultSiblings = _mapper.Map<AdultSiblingsModelView>(context.Message);
            await _adultSiblingsModelViewRepository.AddAsync(mappedAdultSiblings);
        }
    }
}
