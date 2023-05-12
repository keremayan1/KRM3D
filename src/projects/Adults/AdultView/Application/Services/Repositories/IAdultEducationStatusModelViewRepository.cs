using Core.Persistance.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories
{
    public interface IAdultEducationStatusModelViewRepository : IAsyncRepository<AdultEducationStatusModelView>, IRepository<AdultEducationStatusModelView>
    {
    }
}
