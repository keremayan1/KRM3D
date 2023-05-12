using Application.Services.Repositories;
using Core.Persistance.Repositories.EntityFramework;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories
{
    public class AdultEducationStatusModelViewRepository : EfRepositoryBase<AdultEducationStatusModelView, MySQLContext>, IAdultEducationStatusModelViewRepository
    {
        public AdultEducationStatusModelViewRepository(MySQLContext context) : base(context)
        {
        }
    }
}
