using Application.Features.QuestionTitle.Messages;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MassTransit;

namespace Application.Features.QuestionTitle.Consumers
{
    public class UpdateAdultQuestionTitleMessageConsumer : IConsumer<UpdateAdultQuestionTitleMessage>
    {
        private readonly IAdultQuestionTitleModelViewRepository _adultQuestionTitleModelViewRepository;
        private readonly IMapper _mapper;

        public UpdateAdultQuestionTitleMessageConsumer(IAdultQuestionTitleModelViewRepository adultQuestionTitleModelViewRepository, IMapper mapper)
        {
            _adultQuestionTitleModelViewRepository = adultQuestionTitleModelViewRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<UpdateAdultQuestionTitleMessage> context)
        {
            var mappedAdultQuestionTitle = _mapper.Map<AdultQuestionTitleModelView>(context.Message);
            await _adultQuestionTitleModelViewRepository.UpdateAsync(mappedAdultQuestionTitle);
        }
    }
}
