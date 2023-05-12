using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.QuestionAnswer.Messages
{
    public class CreateAdultQuestionAnswerMessage
    {
        public string _id { get; set; }
        public string QuestionId { get; set; }
        public string QuestionAnswer { get; set; }
    }
}
