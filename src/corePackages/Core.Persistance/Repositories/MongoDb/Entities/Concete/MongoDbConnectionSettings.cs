using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistance.Repositories.MongoDb.Entities.Concete
{
    public class MongoDbConnectionSettings
    {
        public  string ConnectionString { get; set ; }
        public string DatabaseName { get; set ; }
    }
}
