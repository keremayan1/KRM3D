using Application.Services.Repositories;
using AutoMapper;
using Core.Tools.RabbitMQ.Messages.QuestionAnswer;
using Core.Tools.RabbitMQ.Messages.QuestionTitle;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestionTitles = Domain.Entities.QuestionTitle;
namespace Application.Features.QuestionAnswer.Consumers
{
    public class UpdateQuestionTitleMessageConsumer : IConsumer<UpdateQuestionTitleMessage>
    {
        private readonly IQuestionTitleRepository _questionTitleRepository;
        private readonly IMapper _mapper;

        public UpdateQuestionTitleMessageConsumer(IQuestionTitleRepository questionTitleRepository, IMapper mapper)
        {
            _questionTitleRepository = questionTitleRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<UpdateQuestionTitleMessage> context)
        {
            var mappedQuestionAnswer = _mapper.Map<QuestionTitles>(context.Message);
            await _questionTitleRepository.UpdateAsync(mappedQuestionAnswer);
        }
    }
}
