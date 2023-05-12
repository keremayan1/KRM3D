using Application.Services.Repositories;
using Core.Persistance.Repositories.EntityFramework;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories
{
    public class AdultFatherModelViewRepository : EfRepositoryBase<AdultFatherModelView, MySQLContext>, IAdultFatherModelViewRepository
    {
        public AdultFatherModelViewRepository(MySQLContext context) : base(context)
        {
        }
    }

}
