using Child.Application.Services.Repositories;
using Core.Persistance.Repositories.MongoDb.DataAccess.Concrete;
using Core.Persistance.Repositories.MongoDb.Entities.Concete;
using Microsoft.Extensions.Options;
using child = Child.Domain.Entities;
namespace Child.Persistance.Repositories
{
    public class ChildRepository : MongoDbRepository<child.Child>, IChildRepository
    {
        public ChildRepository(IOptions<MongoDbConnectionSettings> connectionSettings) : base(connectionSettings)
        {
        }
    }
}
