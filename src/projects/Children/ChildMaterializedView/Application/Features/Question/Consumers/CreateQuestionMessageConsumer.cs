using Application.Services.Repositories;
using AutoMapper;
using Core.Tools.RabbitMQ.Messages.Question;
using MassTransit;
using Questions = Domain.Entities.Question;
namespace Application.Features.Question.Consumers
{
    public class CreateQuestionMessageConsumer : IConsumer<CreateQuestionMessage>
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IMapper _mapper;

        public CreateQuestionMessageConsumer(IQuestionRepository questionRepository, IMapper mapper)
        {
            _questionRepository = questionRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<CreateQuestionMessage> context)
        {
            var question = new Questions
            {
                _id = context.Message._id,
                QuestionTitleId = context.Message.QuestionTitleId,
                QuestionName = context.Message.QuestionName,
            };
            await _questionRepository.AddAsync(question);
        }
    }
}
