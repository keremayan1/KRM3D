using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionAnswer.Business.DTO
{
    public class CreatedQuestionAnswerDto
    {
        public string QuestionId { get; set; }
        public string ChildrenId { get; set; }
        public string Answer { get; set; }
    }
}
