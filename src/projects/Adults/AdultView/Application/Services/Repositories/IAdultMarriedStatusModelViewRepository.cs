using Core.Persistance.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories
{
    public interface IAdultMarriedStatusModelViewRepository : IAsyncRepository<AdultMarriedStatusModelView>, IRepository<AdultMarriedStatusModelView>
    {
    }
}
