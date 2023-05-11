using Application.Services.Repositories;
using Core.Persistance.Repositories.EntityFramework;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories
{
    public class ChildSiblingsRepository : EfRepositoryBase<ChildSiblings, SQLContext>, IChildSiblingsRepository
    {
        public ChildSiblingsRepository(SQLContext context) : base(context)
        {
        }
    }

}
