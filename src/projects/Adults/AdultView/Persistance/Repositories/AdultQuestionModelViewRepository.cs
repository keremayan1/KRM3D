using Application.Services.Repositories;
using Core.Persistance.Repositories.EntityFramework;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories
{
    public class AdultQuestionModelViewRepository : EfRepositoryBase<AdultQuestionModelView, MySQLContext>, IAdultQuestionModelViewRepository
    {
        public AdultQuestionModelViewRepository(MySQLContext context) : base(context)
        {
        }
    }
}
