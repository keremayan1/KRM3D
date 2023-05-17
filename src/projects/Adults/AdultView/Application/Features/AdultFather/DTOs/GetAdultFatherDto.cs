using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AdultFather.DTOs
{
    public class GetAdultFatherDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EducationStatusName { get; set; }
        public int Age { get; set; }
        public string Job { get; set; }
        public string TelephoneNumber { get; set; }
        public string HowManyChildHave { get; set; }
        public string IsLiveWith { get; set; }
    }
}
