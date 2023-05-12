using Application.Features.QuestionAnswer.Messages;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MassTransit;

namespace Application.Features.QuestionAnswer.Consumers
{
    public class UpdateAdultQuestionAnswerMessageConsumer : IConsumer<UpdateAdultQuestionAnswerMessage>
    {
        private readonly IAdultQuestionAnswerModelViewRepository _adultQuestionAnswerModelViewRepository;
        private readonly IMapper _mapper;

        public UpdateAdultQuestionAnswerMessageConsumer(IAdultQuestionAnswerModelViewRepository adultQuestionAnswerModelViewRepository, IMapper mapper)
        {
            _adultQuestionAnswerModelViewRepository = adultQuestionAnswerModelViewRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<UpdateAdultQuestionAnswerMessage> context)
        {
            var mappedAdultQuestionAnswer = _mapper.Map<AdultQuestionAnswerModelView>(context.Message);
            await _adultQuestionAnswerModelViewRepository.UpdateAsync(mappedAdultQuestionAnswer);
        }
    }
}
