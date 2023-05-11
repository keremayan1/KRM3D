using Application.Services.Repositories;
using AutoMapper;
using Core.Tools.RabbitMQ.Messages.ChildSiblings;
using MassTransit;
using childSiblings = Domain.Entities.ChildSiblings;


namespace Application.Features.ChildSiblings.Consumers
{
    public class CreateChildSiblingsMessageConsumer : IConsumer<CreateChildSiblingsMessage>
    {
        private readonly IChildSiblingsRepository _childSiblingsRepository;
        private readonly IMapper _mapper;

        public CreateChildSiblingsMessageConsumer(IChildSiblingsRepository childSiblingsRepository, IMapper mapper)
        {
            _childSiblingsRepository = childSiblingsRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<CreateChildSiblingsMessage> context)
        {
            var mappedChildSiblings = _mapper.Map<childSiblings>(context.Message);
            await _childSiblingsRepository.AddAsync(mappedChildSiblings);
        }
    }

}
