using Core.Persistance.Repositories;
using Core.Persistance.Repositories.MongoDb.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using genders = Gender.Domain.Entities;
namespace Gender.Application.Services.Repositories
{
    public interface IGenderRepository:IMongoDbRepository<genders.Gender>
    {
    }
}
