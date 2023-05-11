using Application.Services.Repositories;
using AutoMapper;
using Core.Tools.RabbitMQ.Messages.EducationStatus;
using MassTransit;
using EducationStatuses = Domain.Entities.EducationStatusReadModel;
namespace Application.Features.EducationStatus.Consumers
{
    public class CreateEducationStatusMessageConsumer : IConsumer<CreateEducationStatusMessage>
    {
        private IEducationStatusRepository _educationStatusRepository;
        private IMapper _mapper;

        public CreateEducationStatusMessageConsumer(IEducationStatusRepository educationStatusRepository, IMapper mapper)
        {
            _educationStatusRepository = educationStatusRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<CreateEducationStatusMessage> context)
        {
            var mappedEducationStatus = _mapper.Map<EducationStatuses>(context.Message);
            await _educationStatusRepository.AddAsync(mappedEducationStatus);
        }
    }

}
