using Application.Services.Repositories;
using Core.Persistance.Repositories.EntityFramework;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories
{
    public class AdultSiblingsModelViewRepository : EfRepositoryBase<AdultSiblingsModelView, MySQLContext>, IAdultSiblingsModelViewRepository
    {
        public AdultSiblingsModelViewRepository(MySQLContext context) : base(context)
        {
        }
    }

}
