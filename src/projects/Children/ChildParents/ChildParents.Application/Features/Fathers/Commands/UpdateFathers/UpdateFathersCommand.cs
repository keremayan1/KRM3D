using AutoMapper;
using ChildParents.Application.Features.Fathers.DTOs;
using ChildParents.Application.Features.Mothers.DTOs;
using ChildParents.Application.Services.Repositories;
using ChildParents.Domain.Entities;
using Core.Tools.RabbitMQ.Messages.ChildParents.Fathers;
using MassTransit;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildParents.Application.Features.Fathers.Commands.UpdateFathers
{
    public class UpdateFathersCommand : IRequest<UpdatedFatherDto>
    {

        public string Id { get; set; }
        public string ChildrenId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EducationStatusId { get; set; }
        public string Job { get; set; }
        public string TelephoneNumber { get; set; }
        public class UpdateFathersCommandHandler : IRequestHandler<UpdateFathersCommand, UpdatedFatherDto>
        {
            private readonly IFatherRepository _fatherRepository;
            private readonly IMapper _mapper;
            private readonly IPublishEndpoint _publishEndpoint;


            public UpdateFathersCommandHandler(IFatherRepository fatherRepository, IMapper mapper, IPublishEndpoint publishEndpoint)
            {
                _fatherRepository = fatherRepository;
                _mapper = mapper;
                _publishEndpoint = publishEndpoint;
            }

            public async Task<UpdatedFatherDto> Handle(UpdateFathersCommand request, CancellationToken cancellationToken)
            {
                var mappedFather = _mapper.Map<Father>(request);
                await _fatherRepository.UpdateAsync(mappedFather.Id, mappedFather);
                var result = _mapper.Map<UpdatedFatherDto>(mappedFather);
                await _publishEndpoint.Publish<UpdateChildFatherMessage>(mappedFather);
                return result;
            }
        }
    }
}
