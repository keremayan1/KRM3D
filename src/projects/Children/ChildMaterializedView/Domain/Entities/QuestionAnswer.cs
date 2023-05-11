using Core.Persistance.Repositories.EntityFramework;

namespace Domain.Entities
{
    public class QuestionAnswer : Entity
    {
        public string Id { get; set; }
        public string QuestionId { get; set; }
        public string ChildrenId { get; set; }
        public string Answer { get; set; }
        public virtual Child? Child { get; set; }
        public virtual Question? Question { get; set; }
       

        public QuestionAnswer()
        {

        }

        public QuestionAnswer(string id, string questionId, string childrenId, string answer):this()
        {
            Id = id;
            QuestionId = questionId;
            ChildrenId = childrenId;
            Answer = answer;
        }
    }
}
