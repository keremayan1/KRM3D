using Application.Services.Repositories;
using AutoMapper;
using Core.Tools.RabbitMQ.Messages.ChildParents.Mothers;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cm = Domain.Entities;
namespace Application.Features.ChildMother.Consumers
{
    public class DeleteChildMotherMessageConsumer : IConsumer<DeleteChildMotherMessage>
    {
        private readonly IChildMotherRepository _childMotherRepository;
        private IMapper _mapper;

        public DeleteChildMotherMessageConsumer(IChildMotherRepository childMotherRepository, IMapper mapper)
        {
            _childMotherRepository = childMotherRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<DeleteChildMotherMessage> context)
        {
            var mappedMother = _mapper.Map<cm.ChildMother>(context.Message);
            await _childMotherRepository.DeleteAsync(mappedMother);
        }
    }
}
