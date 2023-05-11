using Core.Persistance.Repositories.MongoDb.Entities.Concete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gender.Domain.Entities
{
    public class Gender:MongoDbEntity
    {
        public string GenderName { get; set; }

    }
}
