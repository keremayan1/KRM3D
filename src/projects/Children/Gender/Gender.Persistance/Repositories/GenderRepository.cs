using Core.Persistance.Repositories.MongoDb.DataAccess.Concrete;
using Core.Persistance.Repositories.MongoDb.Entities.Concete;
using Gender.Application.Services.Repositories;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using genders = Gender.Domain.Entities;
namespace Gender.Persistance.Repositories
{
    public class GenderRepository : MongoDbRepository<genders.Gender>, IGenderRepository
    {
        public GenderRepository(IOptions<MongoDbConnectionSettings> connectionSettings) : base(connectionSettings)
        {
        }
    }
}
