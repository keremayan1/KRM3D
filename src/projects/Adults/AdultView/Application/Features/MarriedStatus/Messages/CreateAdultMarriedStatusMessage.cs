using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.MarriedStatus.Messages
{
    public class CreateAdultMarriedStatusMessage
    {
        public string _id { get; set; }
        public string MarriedStatusName { get; set; }
    }
}
