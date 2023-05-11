using Application.Services.Repositories;
using AutoMapper;
using Core.Tools.RabbitMQ.Messages.QuestionAnswer;
using Core.Tools.RabbitMQ.Messages.QuestionTitle;
using MassTransit;
using QuestionTitles = Domain.Entities.QuestionTitle;

namespace Application.Features.QuestionAnswer.Consumers
{
    public class DeleteQuestionTitleMessageConsumer : IConsumer<DeleteQuestionTitleMessage>
    {
        private IQuestionTitleRepository _questionTitleRepository;
        private IMapper _mapper;

        public DeleteQuestionTitleMessageConsumer(IQuestionTitleRepository questionTitleRepository, IMapper mapper)
        {
            _questionTitleRepository = questionTitleRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<DeleteQuestionTitleMessage> context)
        {
            var mappedQuestionTitle = _mapper.Map<QuestionTitles>(context.Message);
            await _questionTitleRepository.DeleteAsync(mappedQuestionTitle);
        }
    }
}
