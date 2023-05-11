using Application.Services.Repositories;
using AutoMapper;
using Core.Tools.RabbitMQ.Messages.QuestionAnswer;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestionAnswers = Domain.Entities.QuestionAnswer;
namespace Application.Features.QuestionAnswer.Consumers
{
    public class UpdateQuestionAnswerMessageConsumer : IConsumer<UpdateQuestionAnswerMessage>
    {
        private readonly IQuestionAnswerRepository _questionAnswerRepository;
        private readonly IMapper _mapper;

        public UpdateQuestionAnswerMessageConsumer(IQuestionAnswerRepository questionAnswerRepository, IMapper mapper)
        {
            _questionAnswerRepository = questionAnswerRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<UpdateQuestionAnswerMessage> context)
        {
            var mappedQuestionAnswer = _mapper.Map<QuestionAnswers>(context.Message);
            await _questionAnswerRepository.UpdateAsync(mappedQuestionAnswer);
        }
    }
}
