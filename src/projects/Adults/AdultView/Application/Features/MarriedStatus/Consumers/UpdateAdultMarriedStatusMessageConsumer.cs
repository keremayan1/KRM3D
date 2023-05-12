using Application.Features.MarriedStatus.Messages;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MassTransit;

namespace Application.Features.MarriedStatus.Consumers
{
    public class UpdateAdultMarriedStatusMessageConsumer : IConsumer<UpdateAdultMarriedStatusMessage>
    {
        private readonly IAdultMarriedStatusModelViewRepository _adultMarriedStatusModelViewRepository;
        private readonly IMapper _mapper;

        public UpdateAdultMarriedStatusMessageConsumer(IAdultMarriedStatusModelViewRepository adultMarriedStatusModelViewRepository, IMapper mapper)
        {
            _adultMarriedStatusModelViewRepository = adultMarriedStatusModelViewRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<UpdateAdultMarriedStatusMessage> context)
        {
            var mappedAdultMarriedStatus = _mapper.Map<AdultMarriedStatusModelView>(context.Message);
            await _adultMarriedStatusModelViewRepository.UpdateAsync(mappedAdultMarriedStatus);
        }
    }
}
