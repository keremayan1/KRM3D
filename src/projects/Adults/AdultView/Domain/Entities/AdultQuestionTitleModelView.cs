using Core.Persistance.Repositories.EntityFramework;

namespace Domain.Entities
{
    public class AdultQuestionTitleModelView : Entity
    {
        public string _id { get; set; }
        public string QuestionTitleName { get; set; }
        public AdultQuestionTitleModelView()
        {

        }

        public AdultQuestionTitleModelView(string ıd, string questionTitleName)
        {
            _id = ıd;
            QuestionTitleName = questionTitleName;
        }
    }
}
