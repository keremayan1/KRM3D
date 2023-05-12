using Core.Persistance.Repositories.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class AdultModelView : Entity
    {
        public string _id { get; set; }
        public string GenderId { get; set; }
        public string EducationStatusId { get; set; }
        public string MarriedStatusId { get; set; }
        public string NationalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EthnicName { get; set; }
        public string ReligionName { get; set; }
        public string Job { get; set; }
        public string IsLiveWith { get; set; }
        public string DidSheHeComeWith { get; set; }
        public string PersonComesFromHere { get; set; }
        public string ReasonOfApplication { get; set; }

    }
}
