using Core.Persistance.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories
{
    public interface IAdultQuestionTitleModelViewRepository : IAsyncRepository<AdultQuestionTitleModelView>, IRepository<AdultQuestionTitleModelView>
    {
    }
}
