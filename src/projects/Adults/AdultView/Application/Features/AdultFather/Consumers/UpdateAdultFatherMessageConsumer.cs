using Application.Features.AdultFather.Messages;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MassTransit;

namespace Application.Features.AdultFather.Consumers
{
    public class UpdateAdultFatherMessageConsumer : IConsumer<UpdateAdultFatherMessage>
    {
        private readonly IAdultFatherModelViewRepository _adultFatherModelViewRepository;
        private readonly IMapper _mapper;

        public UpdateAdultFatherMessageConsumer(IAdultFatherModelViewRepository adultFatherModelViewRepository, IMapper mapper)
        {
            _adultFatherModelViewRepository = adultFatherModelViewRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<UpdateAdultFatherMessage> context)
        {
            var mappedAdultFather = _mapper.Map<AdultFatherModelView>(context.Message);
            await _adultFatherModelViewRepository.UpdateAsync(mappedAdultFather);
        }
    }
}
