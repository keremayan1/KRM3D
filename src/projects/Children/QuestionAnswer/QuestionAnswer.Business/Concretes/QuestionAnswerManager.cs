using AutoMapper;
using Core.Tools.RabbitMQ.Messages.QuestionAnswer;
using MassTransit;
using QuestionAnswer.Business.Abstracts;
using QuestionAnswer.Business.DTO;
using QuestionAnswer.Business.Rules;
using QuestionAnswer.DataAccess.Abstract;
using qa = QuestionAnswer.Entities.Concrete;

namespace QuestionAnswer.Business.Concretes
{
    public class QuestionAnswerManager : IQuestionAnswerService
    {
        private readonly IQuestionAnswerDal _questionAnswerDal;
        private readonly IMapper _mapper;
        private readonly QuestionAnswerBusinessRules _questionAnswerBusinessRules;
        private readonly IPublishEndpoint _publishEndpoint;

        public QuestionAnswerManager(IQuestionAnswerDal questionAnswerDal, IMapper mapper, QuestionAnswerBusinessRules questionAnswerBusinessRules, IPublishEndpoint publishEndpoint)
        {
            _questionAnswerDal = questionAnswerDal;
            _mapper = mapper;
            _questionAnswerBusinessRules = questionAnswerBusinessRules;
            _publishEndpoint = publishEndpoint;
        }

        public async Task<List<CreatedQuestionAnswerDto>> AddAll(List<CreatedQuestionAnswerDto> createdQuestionAnswerDtos)
        {
            foreach (var createdQuestionAnswerDto in createdQuestionAnswerDtos)
            {
                var mappedQuestionAnswer = _mapper.Map<qa.QuestionAnswer>(createdQuestionAnswerDto);
                _questionAnswerBusinessRules.ToUpper(mappedQuestionAnswer);
                _questionAnswerBusinessRules.Trim(mappedQuestionAnswer);
                
                await _questionAnswerDal.AddAsync(mappedQuestionAnswer);

                await _publishEndpoint.Publish<CreateQuestionAnswerMessage>(mappedQuestionAnswer);
            }
            return createdQuestionAnswerDtos;
        }

        public async Task<DeletedQuestionAnswerDto> Delete(string id)
        {
            var getId = await _questionAnswerDal.GetByIdAsync(id);
            await _questionAnswerDal.DeleteAsync(getId);
            var result = _mapper.Map<DeletedQuestionAnswerDto>(getId);
            await _publishEndpoint.Publish<DeleteQuestionAnswerMessage>(getId);
            return result;
        }

        public async Task<UpdatedQuestionAnswerDto> Update(UpdatedQuestionAnswerDto updatedQuestionAnswerDto)
        {
            var mappedQuestionAnswer = _mapper.Map<qa.QuestionAnswer>(updatedQuestionAnswerDto);
            await _questionAnswerDal.UpdateAsync(mappedQuestionAnswer.Id, mappedQuestionAnswer);
            await _publishEndpoint.Publish<UpdateQuestionAnswerMessage>(mappedQuestionAnswer);
            var result = _mapper.Map<UpdatedQuestionAnswerDto>(mappedQuestionAnswer);
            return result;
        }
    }
}
