using Core.Persistance.Repositories.MongoDb.DataAccess.Concrete;
using Core.Persistance.Repositories.MongoDb.Entities.Concete;
using Microsoft.Extensions.Options;
using QuestionAnswer.DataAccess.Abstract;
using qa=QuestionAnswer.Entities.Concrete;


namespace QuestionAnswer.DataAccess.Concrete.MongoDb
{
    public class MongoDbQuestionAnswerDal : MongoDbRepository<qa.QuestionAnswer>, IQuestionAnswerDal
    {
        public MongoDbQuestionAnswerDal(IOptions<MongoDbConnectionSettings> connectionSettings) : base(connectionSettings)
        {
        }
    }
}
