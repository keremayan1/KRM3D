using Application.Services.Repositories;
using AutoMapper;
using Core.Tools.RabbitMQ.Messages.ChildParents.Mothers;
using MassTransit;
using ch = Domain.Entities.ChildMother;
namespace Application.Features.ChildMother.Consumers
{
    public class CreateChildMotherMessageConsumer : IConsumer<CreateChildMotherMessage>
    {
        private readonly IChildMotherRepository _childMotherRepository;
        private readonly IMapper _mapper;
        public CreateChildMotherMessageConsumer(IChildMotherRepository childMotherRepository, IMapper mapper)
        {
            _childMotherRepository = childMotherRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<CreateChildMotherMessage> context)
        {
            var mappedMother = _mapper.Map<ch>(context.Message);
            await _childMotherRepository.AddAsync(mappedMother);
        }
    }
}
