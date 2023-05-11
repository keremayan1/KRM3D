using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.RabbitMQ.Messages.EducationStatus
{
    public class CreateEducationStatusMessage
    {
        public string Id { get; set; }
        public string EducationStatusName { get; set; }
       
    }
}
