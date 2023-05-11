using Application.Services.Repositories;
using AutoMapper;
using Core.Tools.RabbitMQ.Messages.QuestionAnswer;
using Core.Tools.RabbitMQ.Messages.QuestionTitle;
using MassTransit;
using qa = Domain.Entities;

namespace Application.Features.QuestionAnswer.Consumers
{
    public class CreateQuestionTitleMessageConsumer : IConsumer<CreateQuestionTitleMessage>
    {
        private readonly IQuestionTitleRepository _questionTitleRepository;
        private readonly IMapper _mapper;

        public CreateQuestionTitleMessageConsumer(IQuestionTitleRepository questionTitleRepository, IMapper mapper)
        {
            _questionTitleRepository = questionTitleRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<CreateQuestionTitleMessage> context)
        {
            var mappedQuestionTitle = _mapper.Map<qa.QuestionTitle>(context.Message);
            await _questionTitleRepository.AddAsync(mappedQuestionTitle);
        }
    }
}
