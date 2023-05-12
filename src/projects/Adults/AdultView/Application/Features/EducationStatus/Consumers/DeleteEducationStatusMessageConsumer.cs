using Application.Features.EducationStatus.Messages;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MassTransit;

namespace Application.Features.EducationStatus.Consumers
{
    public class DeleteEducationStatusMessageConsumer : IConsumer<DeleteEducationStatusMessage>
    {
        private readonly IAdultEducationStatusModelViewRepository _adultEducationStatusModelViewRepository;
        private readonly IMapper _mapper;

        public DeleteEducationStatusMessageConsumer(IAdultEducationStatusModelViewRepository adultEducationStatusModelViewRepository, IMapper mapper)
        {
            _adultEducationStatusModelViewRepository = adultEducationStatusModelViewRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<DeleteEducationStatusMessage> context)
        {
            var mappedEducationStatus = _mapper.Map<AdultEducationStatusModelView>(context.Message);
            await _adultEducationStatusModelViewRepository.DeleteAsync(mappedEducationStatus);
        }
    }
}
