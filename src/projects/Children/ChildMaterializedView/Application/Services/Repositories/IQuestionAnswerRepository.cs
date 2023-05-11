using Core.Persistance.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories
{
    public interface IQuestionAnswerRepository : IAsyncRepository<QuestionAnswer>
    {
    }
}
