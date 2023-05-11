using Core.Persistance.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories
{
    public interface IQuestionTitleRepository : IAsyncRepository<QuestionTitle>
    {
    }
}
