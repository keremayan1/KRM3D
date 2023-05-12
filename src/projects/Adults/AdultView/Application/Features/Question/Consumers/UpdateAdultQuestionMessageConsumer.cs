using Application.Features.Question.Messages;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MassTransit;

namespace Application.Features.Question.Consumers
{
    public class UpdateAdultQuestionMessageConsumer : IConsumer<UpdateAdultQuestionMessage>
    {
        private readonly IAdultQuestionModelViewRepository _adultQuestionModelViewRepository;
        private readonly IMapper _mapper;

        public UpdateAdultQuestionMessageConsumer(IAdultQuestionModelViewRepository adultQuestionModelViewRepository, IMapper mapper)
        {
            _adultQuestionModelViewRepository = adultQuestionModelViewRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<UpdateAdultQuestionMessage> context)
        {
            var mappedAdultQuestion = _mapper.Map<AdultQuestionModelView>(context.Message);
            await _adultQuestionModelViewRepository.UpdateAsync(mappedAdultQuestion);
        }
    }
}
