using Application.Services.Repositories;
using AutoMapper;
using Core.Tools.RabbitMQ.Messages.QuestionAnswer;
using MassTransit;
using qa = Domain.Entities;

namespace Application.Features.QuestionAnswer.Consumers
{
    public class CreateQuestionAnswerMessageConsumer : IConsumer<CreateQuestionAnswerMessage>
    {
        private readonly IQuestionAnswerRepository _questionAnswerRepository;
        private readonly IMapper _mapper;

        public CreateQuestionAnswerMessageConsumer(IQuestionAnswerRepository questionAnswerRepository, IMapper mapper)
        {
            _questionAnswerRepository = questionAnswerRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<CreateQuestionAnswerMessage> context)
        {
            var mappedQuestionAnswer = _mapper.Map<qa.QuestionAnswer>(context.Message);
            await _questionAnswerRepository.AddAsync(mappedQuestionAnswer);
        }
    }
}
