using Application.Services.Repositories;
using Core.Persistance.Repositories.EntityFramework;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories
{
    public class AdultMarriedStatusModelViewRepository : EfRepositoryBase<AdultMarriedStatusModelView, MySQLContext>, IAdultMarriedStatusModelViewRepository
    {
        public AdultMarriedStatusModelViewRepository(MySQLContext context) : base(context)
        {
        }
    }


}
