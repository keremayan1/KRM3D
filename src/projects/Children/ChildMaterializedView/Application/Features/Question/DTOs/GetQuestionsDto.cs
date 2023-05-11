using Application.Features.QuestionTitle.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Question.DTOs
{
    public class GetQuestionsDto
    {
        public string QuestionTitle { get; set; }
        public string QuestionName { get; set; }
    }
}
