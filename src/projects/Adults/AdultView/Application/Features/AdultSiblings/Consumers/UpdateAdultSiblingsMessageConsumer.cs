using Application.Features.AdultSiblings.Messages;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MassTransit;

namespace Application.Features.AdultSiblings.Consumers
{
    public class UpdateAdultSiblingsMessageConsumer : IConsumer<UpdateAdultSiblingsMessage>
    {
        private readonly IAdultSiblingsModelViewRepository _adultSiblingsModelViewRepository;
        private readonly IMapper _mapper;

        public UpdateAdultSiblingsMessageConsumer(IAdultSiblingsModelViewRepository adultSiblingsModelViewRepository, IMapper mapper)
        {
            _adultSiblingsModelViewRepository = adultSiblingsModelViewRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<UpdateAdultSiblingsMessage> context)
        {
            var mappedAdultSiblings = _mapper.Map<AdultSiblingsModelView>(context.Message);
            await _adultSiblingsModelViewRepository.UpdateAsync(mappedAdultSiblings);
        }
    }
}
