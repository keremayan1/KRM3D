using Application.Features.Question.Messages;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Question.Consumers
{
    public class CreateAdultQuestionMessageConsumer : IConsumer<CreateAdultQuestionMessage>
    {
        private readonly IAdultQuestionModelViewRepository _adultQuestionModelViewRepository;
        private readonly IMapper _mapper;

        public CreateAdultQuestionMessageConsumer(IAdultQuestionModelViewRepository adultQuestionModelViewRepository, IMapper mapper)
        {
            _adultQuestionModelViewRepository = adultQuestionModelViewRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<CreateAdultQuestionMessage> context)
        {
            var mappedAdultQuestion = _mapper.Map<AdultQuestionModelView>(context.Message);
            await _adultQuestionModelViewRepository.AddAsync(mappedAdultQuestion);
        }
    }
}
