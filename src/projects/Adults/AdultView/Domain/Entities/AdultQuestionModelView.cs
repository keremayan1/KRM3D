using Core.Persistance.Repositories.EntityFramework;

namespace Domain.Entities
{
    public class AdultQuestionModelView : Entity
    {
        public string _id { get; set; }

        public string QuestionTitleId { get; set; }
        public string QuestionName { get; set; }
        public virtual AdultQuestionTitleModelView? AdultQuestionTitle { get; set; }
        public virtual List<AdultQuestionAnswerModelView>? AdultQuestionAnswers { get; set; }
        public AdultQuestionModelView()
        {

        }

        public AdultQuestionModelView(string id, string questionTitleId, string questionName)
        {
            _id = id;
            QuestionTitleId = questionTitleId;
            QuestionName = questionName;
        }
    }
}

