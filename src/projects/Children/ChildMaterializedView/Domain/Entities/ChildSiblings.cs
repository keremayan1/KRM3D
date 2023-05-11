using Core.Persistance.Repositories.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class ChildSiblings:Entity
    {
        public string _id { get; set; }
        public string ChildId { get; set; }
        public string GenderId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string EducationStatusId { get; set; }
        public string Job { get; set; }
        public virtual Child? Child { get; set; }
        public virtual EducationStatusReadModel? EducationStatus { get; set; }
        public virtual GenderReadModel? Gender { get; set; }
        public ChildSiblings()
        {

        }

        public ChildSiblings(string id, string childId, string firstName, string lastName,string genderId, int age, string educationStatusId, string job):this()
        {
            _id = id;
            ChildId = childId;
            FirstName = firstName;
            GenderId= genderId;
            LastName = lastName;
            Age = age;
            EducationStatusId = educationStatusId;
            Job = job;
        }
    }
}
