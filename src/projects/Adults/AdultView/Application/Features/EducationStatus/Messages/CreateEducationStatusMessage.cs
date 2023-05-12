using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.EducationStatus.Messages
{
    public class CreateEducationStatusMessage
    {
        public string Id { get; set; }
        public string EducationStatusName { get; set; }
    }
}
