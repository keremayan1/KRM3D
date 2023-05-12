using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.QuestionTitle.Messages
{
    public class CreateAdultQuestionTitleMessage
    {
        public string _id { get; set; }
        public string QuestionTitleName { get; set; }
    }
}
