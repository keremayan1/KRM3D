using Application.Services.Repositories;
using Core.Persistance.Repositories.EntityFramework;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories
{
    public class QuestionTitleRepository : EfRepositoryBase<QuestionTitle, SQLContext>, IQuestionTitleRepository
    {
        public QuestionTitleRepository(SQLContext context) : base(context)
        {
        }
    }

}
