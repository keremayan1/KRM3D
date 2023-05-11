using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.RabbitMQ.Messages.QuestionTitle
{
    public class CreateQuestionTitleMessage
    {
        public string Id { get; set; }
        public string QuestionTitleName { get; set; }
    }
}
