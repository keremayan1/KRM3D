using Application.Features.EducationStatus.Messages;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MassTransit;

namespace Application.Features.EducationStatus.Consumers
{
    public class UpdateEducationStatusMessageConsumer : IConsumer<UpdateEducationStatusMessage>
    {
        private readonly IAdultEducationStatusModelViewRepository _adultEducationStatusModelViewRepository;
        private readonly IMapper _mapper;

        public UpdateEducationStatusMessageConsumer(IAdultEducationStatusModelViewRepository adultEducationStatusModelViewRepository, IMapper mapper)
        {
            _adultEducationStatusModelViewRepository = adultEducationStatusModelViewRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<UpdateEducationStatusMessage> context)
        {
            var mappedEducationStatus = _mapper.Map<AdultEducationStatusModelView>(context.Message);
            await _adultEducationStatusModelViewRepository.UpdateAsync(mappedEducationStatus);
        }
    }
}
