using Core.Persistance.Repositories.MongoDb.Entities.Concete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTitle.Domain.Entities
{
    public class QuestionTitle:MongoDbEntity
    {
        public string QuestionTitleName { get; set; }

    }
}
