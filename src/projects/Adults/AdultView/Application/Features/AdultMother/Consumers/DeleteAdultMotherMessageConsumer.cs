using Application.Features.AdultMother.Messages;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MassTransit;

namespace Application.Features.AdultMother.Consumers
{
    public class DeleteAdultMotherMessageConsumer : IConsumer<DeleteAdultMotherMessage>
    {
        private readonly IAdultMotherModelViewRepository _adultMotherModelViewRepository;
        private readonly IMapper _mapper;

        public DeleteAdultMotherMessageConsumer(IAdultMotherModelViewRepository adultMotherModelViewRepository, IMapper mapper)
        {
            _adultMotherModelViewRepository = adultMotherModelViewRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<DeleteAdultMotherMessage> context)
        {
            var mappedAdultMother = _mapper.Map<AdultMotherModelView>(context.Message);
            await _adultMotherModelViewRepository.DeleteAsync(mappedAdultMother);
        }
    }
}
