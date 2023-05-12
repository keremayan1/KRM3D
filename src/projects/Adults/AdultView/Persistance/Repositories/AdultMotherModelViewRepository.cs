using Application.Services.Repositories;
using Core.Persistance.Repositories.EntityFramework;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories
{
    public class AdultMotherModelViewRepository : EfRepositoryBase<AdultMotherModelView, MySQLContext>, IAdultMotherModelViewRepository
    {
        public AdultMotherModelViewRepository(MySQLContext context) : base(context)
        {
        }
    }

}
