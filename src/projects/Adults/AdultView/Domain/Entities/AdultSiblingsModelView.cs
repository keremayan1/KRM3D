using Domain.Entities.Abstracts;

namespace Domain.Entities
{
    public class AdultSiblingsModelView : AdultFamilyModelView
    {
        public string GenderId { get; set; }
        public string TelephoneNumber { get; set; }
        public string HowManyChildHave { get; set; }
        public string IsLiveWith { get; set; }

        public AdultSiblingsModelView()
        {

        }

        public AdultSiblingsModelView(string id, string educationStatusId, string firstName, string lastName, string age, string job,string genderId, string telephoneNumber, string howManyChildHave, string isLiveWith) : base(id, educationStatusId, firstName, lastName, age, job)
        {
            GenderId = genderId;
            TelephoneNumber = telephoneNumber;
            HowManyChildHave = howManyChildHave;
            IsLiveWith = isLiveWith;
        }
    }
}
