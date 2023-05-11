using Application.Services.Repositories;
using Core.Persistance.Repositories.EntityFramework;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories
{
    public class ChildMotherRepository : EfRepositoryBase<ChildMother, SQLContext>, IChildMotherRepository
    {
        public ChildMotherRepository(SQLContext context) : base(context)
        {
        }
    }

}
