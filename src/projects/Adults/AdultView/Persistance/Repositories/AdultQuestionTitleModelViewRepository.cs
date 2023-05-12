using Application.Services.Repositories;
using Core.Persistance.Repositories.EntityFramework;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories
{
    public class AdultQuestionTitleModelViewRepository : EfRepositoryBase<AdultQuestionTitleModelView, MySQLContext>, IAdultQuestionTitleModelViewRepository
    {
        public AdultQuestionTitleModelViewRepository(MySQLContext context) : base(context)
        {
        }
    }
}
