using AutoMapper;
using ChildParents.Application.Features.Fathers.DTOs;
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

namespace ChildParents.Application.Features.Fathers.Commands.CreateFathers
{
    public class CreateFathersCommand :IRequest<CreatedFatherDto>
    {
        public bool DoesHaveAFather { get; set; }
        public string ChildrenId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EducationStatusId { get; set; }
        public string Job { get; set; }
        public string TelephoneNumber { get; set; }
        public class CreateFathersCommandHandler : IRequestHandler<CreateFathersCommand, CreatedFatherDto>
        {
            private readonly IFatherRepository _fatherRepository;
            private readonly IMapper _mapper;
            private readonly IPublishEndpoint _publishEndpoint;

            public CreateFathersCommandHandler(IFatherRepository fatherRepository, IMapper mapper, IPublishEndpoint publishEndpoint)
            {
                _fatherRepository = fatherRepository;
                _mapper = mapper;
                _publishEndpoint = publishEndpoint;
            }

            public async Task<CreatedFatherDto> Handle(CreateFathersCommand request, CancellationToken cancellationToken)
            {
                var mappedFather = _mapper.Map<Father>(request);
                if (request.DoesHaveAFather)
                {
                    await _fatherRepository.AddAsync(mappedFather);
                    var result = _mapper.Map<CreatedFatherDto>(mappedFather);
                    await _publishEndpoint.Publish<CreateChildFatherMessage>(new CreateChildFatherMessage { Id = mappedFather.Id, ChildrenId = mappedFather.ChildrenId, EducationStatusId = mappedFather.EducationStatusId, FirstName = mappedFather.FirstName, LastName = mappedFather.LastName, Job = mappedFather.Job, TelephoneNumber = mappedFather.TelephoneNumber });
                    return result;
                }
                return null;
              
            }
        }
    }
}
