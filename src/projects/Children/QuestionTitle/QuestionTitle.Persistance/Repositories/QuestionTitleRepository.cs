using Core.Persistance.Repositories.MongoDb.DataAccess.Concrete;
using Core.Persistance.Repositories.MongoDb.Entities.Concete;
using Microsoft.Extensions.Options;
using QuestionTitle.Application.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using qt = QuestionTitle.Domain.Entities;
namespace QuestionTitle.Persistance.Repositories
{
    public class QuestionTitleRepository : MongoDbRepository<qt.QuestionTitle>, IQuestionTitleRepository
    {
        public QuestionTitleRepository(IOptions<MongoDbConnectionSettings> connectionSettings) : base(connectionSettings)
        {
        }
    }
}
