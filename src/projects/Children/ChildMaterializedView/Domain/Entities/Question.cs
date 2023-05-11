using Core.Persistance.Repositories.EntityFramework;

namespace Domain.Entities
{
    public class Question : Entity
    {
        public string _id { get; set; }
        public string QuestionTitleId { get; set; }
        public string QuestionName { get; set; }
        public virtual QuestionTitle QuestionTitle { get; set; }
        public virtual ICollection<QuestionAnswer> QuestionAnswers { get; set; }
        public Question()
        {

        }

        public Question(string id, string questionTitleId, string questionName):this()
        {
           _id= id;
            QuestionTitleId = questionTitleId;
            QuestionName = questionName;
        }
    }
}
