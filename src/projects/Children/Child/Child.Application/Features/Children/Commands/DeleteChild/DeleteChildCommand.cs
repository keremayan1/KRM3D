using AutoMapper;
using Child.Application.Features.Children.Dtos;
using Child.Application.Services.Repositories;
using Core.Tools.RabbitMQ.Messages.Child;
using MassTransit;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Child.Application.Features.Children.Commands.DeleteChild
{
    public class DeleteChildCommand:IRequest<DeletedChildDto>
    {
        public string Id { get; set; }
        public class DeleteChildCommandHandler : IRequestHandler<DeleteChildCommand, DeletedChildDto>
        {
            private readonly IChildRepository _childRepository;
            private readonly IMapper _mapper;
            private readonly IPublishEndpoint _publishEndpoint;

            public DeleteChildCommandHandler(IChildRepository childRepository, IMapper mapper, IPublishEndpoint publishEndpoint)
            {
                _childRepository = childRepository;
                _mapper = mapper;
                _publishEndpoint = publishEndpoint;
            }

            public async Task<DeletedChildDto> Handle(DeleteChildCommand request, CancellationToken cancellationToken)
            {
                var getId = await _childRepository.GetByIdAsync(request.Id);
                await _childRepository.DeleteAsync(getId);
                await _publishEndpoint.Publish<DeleteChildMessage>(new DeleteChildMessage { Id = getId.Id });
                var result = _mapper.Map<DeletedChildDto>(getId);
                return result;
            }
        }
    }
}
