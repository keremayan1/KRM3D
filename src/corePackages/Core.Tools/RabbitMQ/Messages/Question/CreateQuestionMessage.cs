using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.RabbitMQ.Messages.Question
{
    public class CreateQuestionMessage
    {
        public string _id { get; set; }
        public string QuestionTitleId { get; set; }
        public string QuestionName { get; set; }
    }

}
