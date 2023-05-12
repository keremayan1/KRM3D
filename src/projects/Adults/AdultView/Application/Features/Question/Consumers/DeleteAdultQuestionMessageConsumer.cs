using Application.Features.Question.Messages;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MassTransit;

namespace Application.Features.Question.Consumers
{
    public class DeleteAdultQuestionMessageConsumer : IConsumer<DeleteAdultQuestionMessage>
    {
        private readonly IAdultQuestionModelViewRepository _adultQuestionModelViewRepository;
        private readonly IMapper _mapper;

        public DeleteAdultQuestionMessageConsumer(IAdultQuestionModelViewRepository adultQuestionModelViewRepository, IMapper mapper)
        {
            _adultQuestionModelViewRepository = adultQuestionModelViewRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<DeleteAdultQuestionMessage> context)
        {
            var mappedAdultQuestion = _mapper.Map<AdultQuestionModelView>(context.Message);
            await _adultQuestionModelViewRepository.DeleteAsync(mappedAdultQuestion);
        }
    }
}
