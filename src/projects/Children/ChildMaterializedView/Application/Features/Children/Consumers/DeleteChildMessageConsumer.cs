using Application.Services.Repositories;
using Core.Tools.RabbitMQ.Messages.Child;
using Domain.Entities;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Children.Consumers
{
    public class DeleteChildMessageConsumer : IConsumer<DeleteChildMessage>
    {
        private readonly IChildRepository _childRepository;

        public DeleteChildMessageConsumer(IChildRepository childRepository)
        {
            _childRepository = childRepository;
        }

        public async Task Consume(ConsumeContext<DeleteChildMessage> context)
        {
            var child = new Child
            {
                Id = context.Message.Id
            };
            await _childRepository.DeleteAsync(child);
        }
    }
}
