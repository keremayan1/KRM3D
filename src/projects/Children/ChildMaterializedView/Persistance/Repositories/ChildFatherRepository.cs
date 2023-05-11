using Application.Services.Repositories;
using Core.Persistance.Repositories.EntityFramework;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories
{
    public class ChildFatherRepository : EfRepositoryBase<ChildFather, SQLContext>, IChildFatherRepository
    {
        public ChildFatherRepository(SQLContext context) : base(context)
        {
        }
    }

}
