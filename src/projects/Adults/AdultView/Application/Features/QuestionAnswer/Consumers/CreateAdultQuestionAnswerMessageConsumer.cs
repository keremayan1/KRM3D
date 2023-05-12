using Application.Features.QuestionAnswer.Messages;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.QuestionAnswer.Consumers
{
    public class CreateAdultQuestionAnswerMessageConsumer : IConsumer<CreateAdultQuestionAnswerMessage>
    {
        private readonly IAdultQuestionAnswerModelViewRepository _adultQuestionAnswerModelViewRepository;
        private readonly IMapper _mapper;

        public CreateAdultQuestionAnswerMessageConsumer(IAdultQuestionAnswerModelViewRepository adultQuestionAnswerModelViewRepository, IMapper mapper)
        {
            _adultQuestionAnswerModelViewRepository = adultQuestionAnswerModelViewRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<CreateAdultQuestionAnswerMessage> context)
        {
            var mappedAdultQuestionAnswer = _mapper.Map<AdultQuestionAnswerModelView>(context.Message);
            await _adultQuestionAnswerModelViewRepository.AddAsync(mappedAdultQuestionAnswer);
        }
    }
}
