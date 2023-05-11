using Application.Services.Repositories;
using Core.Persistance.Repositories.EntityFramework;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories
{
    public class ChildRepository : EfRepositoryBase<Child, SQLContext>, IChildRepository
    {
        public ChildRepository(SQLContext context) : base(context)
        {
        }
    }
}
