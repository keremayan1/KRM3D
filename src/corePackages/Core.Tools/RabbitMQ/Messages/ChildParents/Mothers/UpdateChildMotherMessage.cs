using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tools.RabbitMQ.Messages.ChildParents.Mothers
{
    public class UpdateChildMotherMessage
    {
        public string Id { get; set; }
        public string ChildrenId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EducationStatusId { get; set; }
        public string Job { get; set; }
        public string TelephoneNumber { get; set; }
    }
}
