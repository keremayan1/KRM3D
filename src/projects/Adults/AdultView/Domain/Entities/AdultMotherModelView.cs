using Domain.Entities.Abstracts;

namespace Domain.Entities
{
    public class AdultMotherModelView : AdultFamilyModelView
    {
        public string TelephoneNumber { get; set; }
        public string HowManyChildHave { get; set; }
        public string IsLiveWith { get; set; }

        public virtual AdultModelView Adult { get; set; }
        public virtual AdultEducationStatusModelView AdultEducationStatus { get; set; }
        public AdultMotherModelView()
        {

        }

        public AdultMotherModelView(string id, string educationStatusId, string firstName, string lastName, string age, string job, string telephoneNumber, string howManyChildHave, string isLiveWith) : base(id, educationStatusId, firstName, lastName, age, job)
        {
            TelephoneNumber = telephoneNumber;
            HowManyChildHave = howManyChildHave;
            IsLiveWith = isLiveWith;
        }
    }
}
