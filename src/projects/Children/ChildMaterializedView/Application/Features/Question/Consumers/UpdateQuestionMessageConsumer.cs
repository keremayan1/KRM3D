using Application.Services.Repositories;
using AutoMapper;
using Core.Tools.RabbitMQ.Messages.Question;
using MassTransit;
using Questions = Domain.Entities.Question;
namespace Application.Features.Question.Consumers
{
    public class UpdateQuestionMessageConsumer : IConsumer<UpdateQuestionMessage>
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IMapper _mapper;

        public UpdateQuestionMessageConsumer(IQuestionRepository questionRepository, IMapper mapper)
        {
            _questionRepository = questionRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<UpdateQuestionMessage> context)
        {
            var mappedQuestion = _mapper.Map<Questions>(context.Message);
            await _questionRepository.UpdateAsync(mappedQuestion);
        }
    }
}
