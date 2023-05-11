using Core.Persistance.Repositories.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class GenderReadModel : Entity
    {
        public string Id { get; set; }
        public string GenderName { get; set; }

        public GenderReadModel(string id, string genderName):this()
        {
            Id = id;
            GenderName = genderName;
        }

        public GenderReadModel()
        {

        }
    }
}
