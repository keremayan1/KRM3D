using Core.Persistance.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories
{
    public interface IEducationStatusRepository : IAsyncRepository<EducationStatusReadModel>
    {
    }
}
