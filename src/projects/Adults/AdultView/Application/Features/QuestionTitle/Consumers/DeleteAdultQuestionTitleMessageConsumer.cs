using Application.Features.QuestionTitle.Messages;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MassTransit;

namespace Application.Features.QuestionTitle.Consumers
{
    public class DeleteAdultQuestionTitleMessageConsumer : IConsumer<DeleteAdultQuestionTitleMessage>
    {
        private readonly IAdultQuestionTitleModelViewRepository _adultQuestionTitleModelViewRepository;
        private readonly IMapper _mapper;

        public DeleteAdultQuestionTitleMessageConsumer(IAdultQuestionTitleModelViewRepository adultQuestionTitleModelViewRepository, IMapper mapper)
        {
            _adultQuestionTitleModelViewRepository = adultQuestionTitleModelViewRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<DeleteAdultQuestionTitleMessage> context)
        {
            var mappedAdultQuestionTitle = _mapper.Map<AdultQuestionTitleModelView>(context.Message);
            await _adultQuestionTitleModelViewRepository.DeleteAsync(mappedAdultQuestionTitle);
        }
    }
}
