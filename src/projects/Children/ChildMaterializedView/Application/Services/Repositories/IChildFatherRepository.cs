using Core.Persistance.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories
{
    public interface IChildFatherRepository : IAsyncRepository<ChildFather>
    {
    }
}
