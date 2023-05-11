using Application.Services.Repositories;
using Core.Persistance.Repositories.EntityFramework;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories
{
    public class QuestionRepository : EfRepositoryBase<Question, SQLContext>, IQuestionRepository
    {
        public QuestionRepository(SQLContext context) : base(context)
        {
        }
    }

}
