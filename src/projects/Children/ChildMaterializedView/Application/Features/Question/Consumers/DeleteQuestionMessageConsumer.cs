using Application.Services.Repositories;
using AutoMapper;
using Core.Tools.RabbitMQ.Messages.Question;
using MassTransit;
using Questions = Domain.Entities.Question;
namespace Application.Features.Question.Consumers
{
    public class DeleteQuestionMessageConsumer : IConsumer<DeleteQuestionMessage>
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IMapper _mapper;

        public DeleteQuestionMessageConsumer(IQuestionRepository questionRepository, IMapper mapper)
        {
            _questionRepository = questionRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<DeleteQuestionMessage> context)
        {
            var mappedQuestion = _mapper.Map<Questions>(context.Message);
            await _questionRepository.DeleteAsync(mappedQuestion);
        }
    }
}
