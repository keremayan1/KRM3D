using AutoMapper;
using Core.Tools.RabbitMQ.Messages.QuestionTitle;
using MassTransit;
using MediatR;
using QuestionTitle.Application.Features.QuestionTitles.Dtos;
using QuestionTitle.Application.Services.Repositories;
using qt = QuestionTitle.Domain.Entities;
namespace QuestionTitle.Application.Features.QuestionTitles.Commands.UpdateQuestionTitle
{
    public class UpdateQuestionTitleCommand:IRequest<UpdatedQuestionTitleDto>
    {
        public string Id { get; set; }
        public string QuestionTitleName { get; set; }
        public class UpdateQuestionTitleCommandHandler : IRequestHandler<UpdateQuestionTitleCommand, UpdatedQuestionTitleDto>
        {
            private readonly IQuestionTitleRepository _questionTitleRepository;
            private readonly IMapper _mapper;
            private readonly IPublishEndpoint _publishEndpoint;
            public UpdateQuestionTitleCommandHandler(IQuestionTitleRepository questionTitleRepository, IMapper mapper, IPublishEndpoint publishEndpoint)
            {
                _questionTitleRepository = questionTitleRepository;
                _mapper = mapper;
                _publishEndpoint = publishEndpoint;
            }

            public async Task<UpdatedQuestionTitleDto> Handle(UpdateQuestionTitleCommand request, CancellationToken cancellationToken)
            {
                var mappedQuestionTitle = _mapper.Map<qt.QuestionTitle>(request);
                await _questionTitleRepository.UpdateAsync(mappedQuestionTitle.Id, mappedQuestionTitle);
                await _publishEndpoint.Publish<UpdateQuestionTitleMessage>(mappedQuestionTitle);
                var result = _mapper.Map<UpdatedQuestionTitleDto>(mappedQuestionTitle);
                return result;

            }
        }
    }
}
