using Application.Services.Repositories;
using AutoMapper;
using Core.Tools.RabbitMQ.Messages.ChildSiblings;
using MassTransit;
using childSiblings = Domain.Entities.ChildSiblings;


namespace Application.Features.ChildSiblings.Consumers
{
    public class DeleteChildSiblingsMessageConsumer : IConsumer<DeleteChildSiblingsMessage>
    {
        private readonly IChildSiblingsRepository _childSiblingsRepository;
        private readonly IMapper _mapper;

        public DeleteChildSiblingsMessageConsumer(IChildSiblingsRepository childSiblingsRepository, IMapper mapper)
        {
            _childSiblingsRepository = childSiblingsRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<DeleteChildSiblingsMessage> context)
        {
            var mappedChildSiblings = _mapper.Map<childSiblings>(context.Message);
            await _childSiblingsRepository.DeleteAsync(mappedChildSiblings);
        }
    }

}
