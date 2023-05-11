using Core.Persistance.Repositories.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Child:Entity
    {
        public string Id { get; set; }
        public string GenderId { get; set; }
        public string NationalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string SchoolName { get; set; }
        public string ClassName { get; set; }
        public virtual GenderReadModel? Gender { get; set; }
        public virtual ChildFather? ChildFather { get; set; }
        public virtual ChildMother? ChildMother { get; set; }
        public virtual List<ChildSiblings>? ChildSiblings { get; set; }
        public virtual List<QuestionAnswer> QuestionAnswers { get; set; }

        public Child()
        {

        }
        public Child(string id, string genderId, string nationalId, string firstName, string lastName, DateTime dateOfBirth, string schoolName, string className):this() 
        {
            Id = id;
            GenderId = genderId;
            NationalId = nationalId;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            SchoolName = schoolName;
            ClassName = className;
        }
    }
}
