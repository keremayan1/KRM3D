using Application.Features.Question.DTOs;
using Application.Features.QuestionTitle.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.QuestionAnswer.DTOs
{
    public class GetQuestionAnswerDto
    {
        public string QuestionTitleName { get; set; }
        public string QuestionName { get; set; }
        public string Answer { get; set; }

    }
}
