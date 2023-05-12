using Application.Services.Repositories;
using Core.Persistance.Repositories.EntityFramework;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories
{
    public class AdultQuestionAnswerModelViewRepository : EfRepositoryBase<AdultQuestionAnswerModelView, MySQLContext>, IAdultQuestionAnswerModelViewRepository
    {
        public AdultQuestionAnswerModelViewRepository(MySQLContext context) : base(context)
        {
        }
    }
}
