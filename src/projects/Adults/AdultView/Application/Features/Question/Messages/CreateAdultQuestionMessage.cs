using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Question.Messages
{
    public class CreateAdultQuestionMessage
    {
        public string _id { get; set; }
        public string QuestionTitleId { get; set; }
        public string QuestionName { get; set; }
    }
}
