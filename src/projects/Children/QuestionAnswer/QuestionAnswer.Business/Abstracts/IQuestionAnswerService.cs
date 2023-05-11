using QuestionAnswer.Business.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionAnswer.Business.Abstracts
{
    public interface IQuestionAnswerService
    {
        Task<List<CreatedQuestionAnswerDto>> AddAll(List<CreatedQuestionAnswerDto> createdQuestionAnswerDtos);
        Task<UpdatedQuestionAnswerDto> Update(UpdatedQuestionAnswerDto updatedQuestionAnswerDto);
        Task<DeletedQuestionAnswerDto> Delete(string id);
    }
}
