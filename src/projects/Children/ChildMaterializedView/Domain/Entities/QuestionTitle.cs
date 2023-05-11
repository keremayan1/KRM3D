using Core.Persistance.Repositories.EntityFramework;

namespace Domain.Entities
{
    public class QuestionTitle : Entity
    {
        public string Id { get; set; }
        public string QuestionTitleName { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public QuestionTitle()
        {

        }

        public QuestionTitle(string id, string questionTitleName):this()
        {
            Id = id;
            QuestionTitleName = questionTitleName;
        }
    }
}
