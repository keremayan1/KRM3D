using Domain.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class AdultFatherModelView:AdultFamilyModelView
    {
        public string TelephoneNumber{ get; set; }
        public string HowManyChildHave { get; set; }
        public string IsLiveWith { get; set; }

        public AdultFatherModelView()
        {
            
        }

        public AdultFatherModelView(string id, string educationStatusId, string firstName, string lastName, string age, string job,string telephoneNumber,string howManyChildHave,string isLiveWith) : base(id, educationStatusId, firstName, lastName, age, job)
        {
            TelephoneNumber = telephoneNumber;
            HowManyChildHave = howManyChildHave;
            IsLiveWith = isLiveWith;
        }
    }
}
