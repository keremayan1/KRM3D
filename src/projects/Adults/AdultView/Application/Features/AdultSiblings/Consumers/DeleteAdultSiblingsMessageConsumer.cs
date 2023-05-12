using Application.Features.AdultSiblings.Messages;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MassTransit;

namespace Application.Features.AdultSiblings.Consumers
{
    public class DeleteAdultSiblingsMessageConsumer : IConsumer<DeleteAdultSiblingsMessage>
    {
        private readonly IAdultSiblingsModelViewRepository _adultSiblingsModelViewRepository;
        private readonly IMapper _mapper;

        public DeleteAdultSiblingsMessageConsumer(IAdultSiblingsModelViewRepository adultSiblingsModelViewRepository, IMapper mapper)
        {
            _adultSiblingsModelViewRepository = adultSiblingsModelViewRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<DeleteAdultSiblingsMessage> context)
        {
            var mappedAdultSiblings = _mapper.Map<AdultSiblingsModelView>(context.Message);
            await _adultSiblingsModelViewRepository.DeleteAsync(mappedAdultSiblings);
        }
    }
}
