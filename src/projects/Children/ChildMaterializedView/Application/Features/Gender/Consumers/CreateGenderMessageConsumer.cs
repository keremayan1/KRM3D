using Application.Services.Repositories;
using AutoMapper;
using Core.Tools.RabbitMQ.Messages.Gender;
using MassTransit;
using g = Domain.Entities;
namespace Application.Features.Gender.Consumers
{
    public class CreateGenderMessageConsumer : IConsumer<CreateGenderMessage>
    {
        private readonly IGenderRepository _genderRepository;
        private readonly IMapper _mapper;
        public CreateGenderMessageConsumer(IGenderRepository genderRepository, IMapper mapper)
        {
            _genderRepository = genderRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<CreateGenderMessage> context)
        {
            var mappedGender = _mapper.Map<g.GenderReadModel>(context.Message);
            await _genderRepository.AddAsync(mappedGender);
        }
    }
}
