using Application.Features.EducationStatus.Messages;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.EducationStatus.Consumers
{
    public class CreateEducationStatusMessageConsumer : IConsumer<CreateEducationStatusMessage>
    {
        private readonly IAdultEducationStatusModelViewRepository _adultEducationStatusModelViewRepository;
        private readonly IMapper _mapper;

        public CreateEducationStatusMessageConsumer(IAdultEducationStatusModelViewRepository adultEducationStatusModelViewRepository, IMapper mapper)
        {
            _adultEducationStatusModelViewRepository = adultEducationStatusModelViewRepository;
            _mapper = mapper;
        }

        public async Task Consume(ConsumeContext<CreateEducationStatusMessage> context)
        {
            var mappedEducationStatus = _mapper.Map<AdultEducationStatusModelView>(context.Message);
            await _adultEducationStatusModelViewRepository.AddAsync(mappedEducationStatus);
        }
    }
}
