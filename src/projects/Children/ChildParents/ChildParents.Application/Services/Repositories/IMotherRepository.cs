using ChildParents.Domain.Entities;
using Core.Persistance.Repositories.MongoDb.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildParents.Application.Services.Repositories
{
    public interface IMotherRepository:IMongoDbRepository<Mother>
    {
    }
}
