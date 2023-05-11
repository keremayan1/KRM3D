using Application.Services.Repositories;
using AutoMapper;
using Core.Tools.RabbitMQ.Messages.QuestionAnswer;
using MassTransit;
using QuestionAnswers = Domain.Entities.QuestionAnswer;

namespace Application.Features.QuestionAnswer.Consumers
{
    public class DeleteQuestionAnswerMessageConsumer : IConsumer<DeleteQuestionAnswerMessage>
    {
        private IQuestionAnswerRepository _questionAnswerRepository;
        private IMapper _mapper;

        public DeleteQuestionAnswerMessageConsumer(IQuestionAnswerRepository questionAnswerRepository, IMapper mapper)
        {
            _questionAnswerRepository = questionAnswerRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<DeleteQuestionAnswerMessage> context)
        {
            var mappedQuestionAnswer = _mapper.Map<QuestionAnswers>(context.Message);
            await _questionAnswerRepository.DeleteAsync(mappedQuestionAnswer);
        }
    }
}
