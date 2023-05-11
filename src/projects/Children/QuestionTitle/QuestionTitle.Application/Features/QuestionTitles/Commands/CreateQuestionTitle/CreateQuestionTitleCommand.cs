using AutoMapper;
using Core.Tools.RabbitMQ.Messages.QuestionTitle;
using MassTransit;
using MediatR;
using QuestionTitle.Application.Features.QuestionTitles.Dtos;
using QuestionTitle.Application.Services.Repositories;
using qt=QuestionTitle.Domain.Entities;
namespace QuestionTitle.Application.Features.QuestionTitles.Commands.CreateQuestionTitle
{
    public class CreateQuestionTitleCommand:IRequest<CreatedQuestionTitleDto>
    {
        public string QuestionTitleName { get; set; }
        public class CreateQuestionTitleCommandHandler : IRequestHandler<CreateQuestionTitleCommand, CreatedQuestionTitleDto>
        {
            private readonly IQuestionTitleRepository _questionTitleRepository;
            private readonly IMapper _mapper;
            private readonly IPublishEndpoint _publishEndpoint;

            public CreateQuestionTitleCommandHandler(IQuestionTitleRepository questionTitleRepository, IMapper mapper, IPublishEndpoint publishEndpoint)
            {
                _questionTitleRepository = questionTitleRepository;
                _mapper = mapper;
                _publishEndpoint = publishEndpoint;
            }

            public async Task<CreatedQuestionTitleDto> Handle(CreateQuestionTitleCommand request, CancellationToken cancellationToken)
            {
                var mappedQuestionTitle = _mapper.Map<qt.QuestionTitle>(request);
                await _questionTitleRepository.AddAsync(mappedQuestionTitle);
                await _publishEndpoint.Publish<CreateQuestionTitleMessage>(mappedQuestionTitle);
                var result = _mapper.Map<CreatedQuestionTitleDto>(mappedQuestionTitle);
                return result;
            }
        }
    }
}
