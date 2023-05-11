using Core.Persistance.Repositories.MongoDb.Entities.Concete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionAnswer.Entities.Concrete
{
    public class QuestionAnswer:MongoDbEntity
    {
        public string QuestionId { get; set; }
        public string ChildrenId { get; set; }
        public string Answer { get; set; }
    }
}
