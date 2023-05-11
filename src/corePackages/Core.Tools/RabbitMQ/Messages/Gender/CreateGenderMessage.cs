using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.RabbitMQ.Messages.Gender
{
    public class CreateGenderMessage
    {
        public string Id { get; set; }
        public string GenderName { get; set; }
    }
}
