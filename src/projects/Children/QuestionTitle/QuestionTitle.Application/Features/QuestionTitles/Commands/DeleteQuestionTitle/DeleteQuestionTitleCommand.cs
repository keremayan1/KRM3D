using AutoMapper;
using AutoMapper.Configuration.Annotations;
using Core.Tools.RabbitMQ.Messages.QuestionTitle;
using MassTransit;
using MediatR;
using QuestionTitle.Application.Features.QuestionTitles.Dtos;
using QuestionTitle.Application.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTitle.Application.Features.QuestionTitles.Commands.DeleteQuestionTitle
{
    public class DeleteQuestionTitleCommand:IRequest<DeletedQuestionTitleDto>
    {
        public string Id { get; set; }
        public class DeleteQuestionTitleCommandHandler : IRequestHandler<DeleteQuestionTitleCommand, DeletedQuestionTitleDto>
        {
            private readonly IQuestionTitleRepository _questionTitleRepository;
            private readonly IMapper _mapper;
            private readonly IPublishEndpoint _publishEndpoint;

            public DeleteQuestionTitleCommandHandler(IQuestionTitleRepository questionTitleRepository, IMapper mapper, IPublishEndpoint publishEndpoint)
            {
                _questionTitleRepository = questionTitleRepository;
                _mapper = mapper;
                _publishEndpoint = publishEndpoint;
            }

            public async Task<DeletedQuestionTitleDto> Handle(DeleteQuestionTitleCommand request, CancellationToken cancellationToken)
            {
                var getId = await _questionTitleRepository.GetByIdAsync(request.Id);
                await _questionTitleRepository.DeleteAsync(getId);
                await _publishEndpoint.Publish<DeleteQuestionTitleMessage>(getId);
                var result = _mapper.Map<DeletedQuestionTitleDto>(getId);
                return result;
            }
        }
    }
}
