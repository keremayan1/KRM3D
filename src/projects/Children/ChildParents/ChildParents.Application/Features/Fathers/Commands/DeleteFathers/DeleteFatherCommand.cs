using AutoMapper;
using ChildParents.Application.Features.Fathers.DTOs;
using ChildParents.Application.Services.Repositories;
using Core.Tools.RabbitMQ.Messages.ChildParents.Fathers;
using MassTransit;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildParents.Application.Features.Fathers.Commands.DeleteFathers
{
    public class DeleteFatherCommand:IRequest<DeletedFathersDto>
    {
        public string Id { get; set; }
        public class DeleteFatherCommandHandler : IRequestHandler<DeleteFatherCommand, DeletedFathersDto>
        {
            private readonly IFatherRepository _fatherRepository;
            private readonly IMapper _mapper;
            private readonly IPublishEndpoint _publishEndpoint;

            public DeleteFatherCommandHandler(IFatherRepository fatherRepository, IMapper mapper, IPublishEndpoint publishEndpoint)
            {
                _fatherRepository = fatherRepository;
                _mapper = mapper;
                _publishEndpoint = publishEndpoint;
            }

            public async Task<DeletedFathersDto> Handle(DeleteFatherCommand request, CancellationToken cancellationToken)
            {
                var getId = await _fatherRepository.GetByIdAsync(request.Id);
                await _fatherRepository.DeleteAsync(getId);
                await _publishEndpoint.Publish<DeleteChildFatherMessage>(new DeleteChildFatherMessage { Id = getId.Id });
                var result = _mapper.Map<DeletedFathersDto>(getId);
                return result;
            }
        }
    }
}
