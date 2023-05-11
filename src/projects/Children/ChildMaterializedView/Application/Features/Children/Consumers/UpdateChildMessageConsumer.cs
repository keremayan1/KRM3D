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
    public class UpdateChildMessageConsumer : IConsumer<UpdateChildMessage>
    {
        private readonly IChildRepository _childRepository;

        public UpdateChildMessageConsumer(IChildRepository childRepository)
        {
            _childRepository = childRepository;
        }

        public async Task Consume(ConsumeContext<UpdateChildMessage> context)
        {
            var child = new Child
            {
                Id = context.Message.Id,
                FirstName = context.Message.FirstName,
                LastName = context.Message.LastName,
                NationalId = context.Message.NationalId,
                ClassName = context.Message.ClassName,
                DateOfBirth = context.Message.DateOfBirth,
                GenderId = context.Message.GenderId,
                SchoolName = context.Message.SchoolName,
            };
            await _childRepository.UpdateAsync(child);

        }
    }
}
