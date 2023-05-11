using Application.Services.Repositories;
using Core.Persistance.Repositories.EntityFramework;
using Domain.Entities;
using Persistance.Contexts;

namespace Persistance.Repositories
{
    public class QuestionAnswerRepository : EfRepositoryBase<QuestionAnswer, SQLContext>, IQuestionAnswerRepository
    {
        public QuestionAnswerRepository(SQLContext context) : base(context)
        {
        }
    }

}
