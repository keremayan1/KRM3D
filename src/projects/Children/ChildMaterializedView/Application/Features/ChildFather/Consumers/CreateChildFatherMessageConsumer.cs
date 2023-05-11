using Application.Services.Repositories;
using AutoMapper;
using Core.Tools.RabbitMQ.Messages.ChildParents.Fathers;
using MassTransit;
using cf = Domain.Entities;
namespace Application.Features.ChildFather.Consumers
{
    public class CreateChildFatherMessageConsumer : IConsumer<CreateChildFatherMessage>
    {
        private readonly IChildFatherRepository _childFatherRepository;
        private readonly IMapper _mapper;

        public CreateChildFatherMessageConsumer(IChildFatherRepository childFatherRepository, IMapper mapper)
        {
            _childFatherRepository = childFatherRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<CreateChildFatherMessage> context)
        {
            var mappedFather = _mapper.Map<cf.ChildFather>(context.Message);
            await _childFatherRepository.AddAsync(mappedFather);
        }
    }
}
