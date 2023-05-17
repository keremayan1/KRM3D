using Core.Persistance.Repositories.EntityFramework;

namespace Domain.Entities.Abstracts
{
    public abstract class AdultFamilyModelView:Entity
    {
        public string _id { get; set; }
        public string AdultId { get; set; }
        public string EducationStatusId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Job { get; set; }

        public AdultFamilyModelView()
        {
            
        }

        protected AdultFamilyModelView(string id, string educationStatusId, string firstName, string lastName, string age, string job)
        {
            _id = id;
            EducationStatusId = educationStatusId;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Job = job;
        }
    }
}
