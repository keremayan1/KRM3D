using Application.Services.Repositories;
using Core.Persistance.Repositories.EntityFramework;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories
{
    public class EducationStatusRepository : EfRepositoryBase<EducationStatusReadModel, SQLContext>, IEducationStatusRepository
    {
        public EducationStatusRepository(SQLContext context) : base(context)
        {
        }
    }

}
