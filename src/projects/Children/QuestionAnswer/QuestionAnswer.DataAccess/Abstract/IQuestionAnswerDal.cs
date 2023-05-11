using Core.Persistance.Repositories.MongoDb.DataAccess;
using qt=QuestionAnswer.Entities.Concrete;


namespace QuestionAnswer.DataAccess.Abstract
{
    public interface IQuestionAnswerDal:IMongoDbRepository<qt.QuestionAnswer>
    {
    }
}
