using Core.Persistance.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories
{
    public interface IGenderRepository:IAsyncRepository<GenderReadModel>
    {
    }
}
