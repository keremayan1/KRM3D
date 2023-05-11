using Application.Services.Repositories;
using AutoMapper;
using Core.Tools.RabbitMQ.Messages.Gender;
using MassTransit;
using g = Domain.Entities;

namespace Application.Features.Gender.Consumers
{
    public class DeleteGenderMessageConsumer : IConsumer<DeleteGenderMessage>
    {
        private IGenderRepository _genderRepository;
        private IMapper _mapper;

        public DeleteGenderMessageConsumer(IGenderRepository genderRepository, IMapper mapper)
        {
            _genderRepository = genderRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<DeleteGenderMessage> context)
        {
            var mappedGender = _mapper.Map<g.GenderReadModel>(context.Message);
            await _genderRepository.DeleteAsync(mappedGender);
        }
    }
}
