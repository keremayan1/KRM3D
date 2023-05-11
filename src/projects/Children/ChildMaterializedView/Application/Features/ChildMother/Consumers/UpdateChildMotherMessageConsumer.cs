using Application.Services.Repositories;
using AutoMapper;
using Core.Tools.RabbitMQ.Messages.ChildParents.Mothers;
using MassTransit;
using cm = Domain.Entities;

namespace Application.Features.ChildMother.Consumers
{
    public class UpdateChildMotherMessageConsumer : IConsumer<UpdateChildMotherMessage>
    {
        private readonly IChildMotherRepository _childMotherRepository;
        private readonly IMapper _mapper;
        public UpdateChildMotherMessageConsumer(IChildMotherRepository childMotherRepository, IMapper mapper)
        {
            _childMotherRepository = childMotherRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<UpdateChildMotherMessage> context)
        {
            var mappedMother = _mapper.Map<cm.ChildMother>(context.Message);
            await _childMotherRepository.UpdateAsync(mappedMother);
        }
    }
}
