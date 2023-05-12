using Core.Persistance.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories
{
    public interface IAdultFatherModelViewRepository : IAsyncRepository<AdultFatherModelView>, IRepository<AdultFatherModelView>
    {
    }
}
