using Core.Persistance.Repositories.MongoDb.DataAccess;
using child = Child.Domain.Entities;
namespace Child.Application.Services.Repositories
{
    public interface IChildRepository:IMongoDbRepository<child.Child>
    {
    }
}
