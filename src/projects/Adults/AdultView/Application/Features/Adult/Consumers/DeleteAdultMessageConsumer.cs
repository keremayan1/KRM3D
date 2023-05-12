using Application.Features.Adult.Messages.Adult;
using Application.Services.Repositories;
using AutoMapper;

using Domain.Entities;
using MassTransit;

namespace Application.Features.Adult.Consumers
{
    public class DeleteAdultMessageConsumer : IConsumer<DeleteAdultMessage>
    {
        private readonly IAdultModelViewRepository _adultModelViewRepository;
        private readonly IMapper _mapper;

        public DeleteAdultMessageConsumer(IAdultModelViewRepository adultModelViewRepository, IMapper mapper)
        {
            _adultModelViewRepository = adultModelViewRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<DeleteAdultMessage> context)
        {
            var mappedAdult = _mapper.Map<AdultModelView>(context.Message);
            await _adultModelViewRepository.DeleteAsync(mappedAdult);
        }
    }
}
