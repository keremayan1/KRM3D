using Application.Features.AdultMother.Messages;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MassTransit;

namespace Application.Features.AdultMother.Consumers
{
    public class UpdateAdultMotherMessageConsumer : IConsumer<UpdateAdultMotherMessage>
    {
        private readonly IAdultMotherModelViewRepository _adultMotherModelViewRepository;
        private readonly IMapper _mapper;

        public UpdateAdultMotherMessageConsumer(IAdultMotherModelViewRepository adultMotherModelViewRepository, IMapper mapper)
        {
            _adultMotherModelViewRepository = adultMotherModelViewRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<UpdateAdultMotherMessage> context)
        {
            var mappedAdultMother = _mapper.Map<AdultMotherModelView>(context.Message);
            await _adultMotherModelViewRepository.UpdateAsync(mappedAdultMother);
        }
    }
}
