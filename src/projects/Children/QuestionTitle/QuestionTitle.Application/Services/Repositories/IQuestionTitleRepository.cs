using Core.Persistance.Repositories.MongoDb.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qt = QuestionTitle.Domain.Entities;
namespace QuestionTitle.Application.Services.Repositories
{
    public interface IQuestionTitleRepository:IMongoDbRepository<qt.QuestionTitle>
    {
    }
}
