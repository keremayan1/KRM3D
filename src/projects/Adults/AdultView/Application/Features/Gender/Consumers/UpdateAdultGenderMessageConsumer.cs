using Application.Features.Gender.Messages;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MassTransit;

namespace Application.Features.Gender.Consumers
{
    public class UpdateAdultGenderMessageConsumer : IConsumer<UpdateAdultGenderMessage>
    {
        private readonly IAdultGenderModelViewRepository _adultGenderModelViewRepository;
        private readonly IMapper _mapper;

        public UpdateAdultGenderMessageConsumer(IAdultGenderModelViewRepository adultGenderModelViewRepository, IMapper mapper)
        {
            _adultGenderModelViewRepository = adultGenderModelViewRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<UpdateAdultGenderMessage> context)
        {
            var mappedAdultGender = _mapper.Map<AdultGenderModelView>(context.Message);
            await _adultGenderModelViewRepository.UpdateAsync(mappedAdultGender);
        }
    }
}
