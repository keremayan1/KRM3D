using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.RabbitMQ.Messages.QuestionAnswer
{
    public class CreateQuestionAnswerMessage
    {
        public string Id { get; set; }
        public string QuestionId { get; set; }
        public string ChildrenId { get; set; }
        public string Answer { get; set; }
    }
}
