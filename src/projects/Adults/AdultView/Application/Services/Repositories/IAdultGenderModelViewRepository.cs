using Core.Persistance.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories
{
    public interface IAdultGenderModelViewRepository : IAsyncRepository<AdultGenderModelView>, IRepository<AdultGenderModelView>
    {
    }
}
