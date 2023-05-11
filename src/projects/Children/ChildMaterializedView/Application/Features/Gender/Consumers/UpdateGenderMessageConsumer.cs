using Application.Services.Repositories;
using AutoMapper;
using Core.Tools.RabbitMQ.Messages.Gender;
using MassTransit;
using g = Domain.Entities;

namespace Application.Features.Gender.Consumers
{
    public class UpdateGenderMessageConsumer : IConsumer<UpdateGenderMessage>
    {
        private IGenderRepository _genderRepository;
        private IMapper _mapper;

        public UpdateGenderMessageConsumer(IGenderRepository genderRepository, IMapper mapper)
        {
            _genderRepository = genderRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<UpdateGenderMessage> context)
        {
            var mappedGender = _mapper.Map<g.GenderReadModel>(context.Message);
            await _genderRepository.UpdateAsync(mappedGender);
        }
    }
}
