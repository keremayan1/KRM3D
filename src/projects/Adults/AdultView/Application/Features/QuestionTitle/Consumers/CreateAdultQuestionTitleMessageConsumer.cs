using Application.Features.QuestionTitle.Messages;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.QuestionTitle.Consumers
{
    public class CreateAdultQuestionTitleMessageConsumer : IConsumer<CreateAdultQuestionTitleMessage>
    {
        private readonly IAdultQuestionTitleModelViewRepository _adultQuestionTitleModelViewRepository;
        private readonly IMapper _mapper;

        public CreateAdultQuestionTitleMessageConsumer(IAdultQuestionTitleModelViewRepository adultQuestionTitleModelViewRepository, IMapper mapper)
        {
            _adultQuestionTitleModelViewRepository = adultQuestionTitleModelViewRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<CreateAdultQuestionTitleMessage> context)
        {
            var mappedAdultQuestionTitle = _mapper.Map<AdultQuestionTitleModelView>(context.Message);
            await _adultQuestionTitleModelViewRepository.AddAsync(mappedAdultQuestionTitle);
        }
    }
}
