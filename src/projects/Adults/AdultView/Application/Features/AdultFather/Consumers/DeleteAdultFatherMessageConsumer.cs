using Application.Features.AdultFather.Messages;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MassTransit;

namespace Application.Features.AdultFather.Consumers
{
    public class DeleteAdultFatherMessageConsumer : IConsumer<DeleteAdultFatherMessage>
    {
        private readonly IAdultFatherModelViewRepository _adultFatherModelViewRepository;
        private readonly IMapper _mapper;

        public DeleteAdultFatherMessageConsumer(IAdultFatherModelViewRepository adultFatherModelViewRepository, IMapper mapper)
        {
            _adultFatherModelViewRepository = adultFatherModelViewRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<DeleteAdultFatherMessage> context)
        {
            var mappedAdultFather = _mapper.Map<AdultFatherModelView>(context.Message);
            await _adultFatherModelViewRepository.DeleteAsync(mappedAdultFather);
        }
    }
}
