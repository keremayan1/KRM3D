using Core.Persistance.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories
{
    public interface IAdultQuestionModelViewRepository : IAsyncRepository<AdultQuestionModelView>, IRepository<AdultQuestionModelView>
    {
    }
}
