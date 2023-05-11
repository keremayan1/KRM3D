using Core.Persistance.Repositories.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class EducationStatusReadModel : Entity
    {
        public string Id { get; set; }
        public string EducationStatusName { get; set; }
        public EducationStatusReadModel()
        {

        }

        public EducationStatusReadModel(string id, string educationStatusName):this()
        {
            Id = id;
            EducationStatusName = educationStatusName;
        }
    }
}
