using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ChildSiblings.DTOs
{
    public class GetListChildSiblingsDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GenderName { get; set; }
        public int Age { get; set; }
        public string EducationStatusName { get; set; }
        public string Job { get; set; }
    }
}
