using Core.Persistance.Repositories.EntityFramework;

namespace Domain.Entities
{
    public class ChildFather:Entity
    {
        public string Id { get; set; }
        public string ChildrenId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EducationStatusId { get; set; }
        public string Job { get; set; }
        public string TelephoneNumber { get; set; }
        public virtual Child Child { get; set; }
        public virtual EducationStatusReadModel EducationStatus { get; set; }

        public ChildFather()
        {

        }

        public ChildFather(string id, string childrenId, string firstName, string lastName, string educationStatusId, string job, string telephoneNumber):this()
        {
            Id = id;
            ChildrenId = childrenId;
            FirstName = firstName;
            LastName = lastName;
            EducationStatusId = educationStatusId;
            Job = job;
            TelephoneNumber = telephoneNumber;
        }
    }
}
