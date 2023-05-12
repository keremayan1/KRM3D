using Application.Services.Repositories;
using AutoMapper;
using Core.Tools.RabbitMQ.Messages.Adults.Adult;
using Domain.Entities;
using MassTransit;

namespace Application.Features.Adult.Consumers
{
    public class UpdateAdultMessageConsumer : IConsumer<UpdateAdultMessage>
    {
        private readonly IAdultModelViewRepository _adultModelViewRepository;
        private readonly IMapper _mapper;

        public UpdateAdultMessageConsumer(IAdultModelViewRepository adultModelViewRepository, IMapper mapper)
        {
            _adultModelViewRepository = adultModelViewRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<UpdateAdultMessage> context)
        {
            var mappedAdult = _mapper.Map<AdultModelView>(context.Message);
            await _adultModelViewRepository.UpdateAsync(mappedAdult);
        }
    }
}
