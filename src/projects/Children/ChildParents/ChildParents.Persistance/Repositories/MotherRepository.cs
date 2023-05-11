using ChildParents.Application.Services.Repositories;
using ChildParents.Domain.Entities;
using Core.Persistance.Repositories.MongoDb.DataAccess.Concrete;
using Core.Persistance.Repositories.MongoDb.Entities.Concete;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildParents.Persistance.Repositories
{
    public class MotherRepository : MongoDbRepository<Mother>, IMotherRepository
    {
        public MotherRepository(IOptions<MongoDbConnectionSettings> connectionSettings) : base(connectionSettings)
        {
        }
    }
}
