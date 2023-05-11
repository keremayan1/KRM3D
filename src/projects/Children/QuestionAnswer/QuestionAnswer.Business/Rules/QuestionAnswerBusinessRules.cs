using QuestionAnswer.DataAccess.Abstract;
using qa = QuestionAnswer.Entities.Concrete;
namespace QuestionAnswer.Business.Rules
{
    public class QuestionAnswerBusinessRules
    {
        private readonly IQuestionAnswerDal _questionAnswerDal;

        public QuestionAnswerBusinessRules(IQuestionAnswerDal questionAnswerDal)
        {
            _questionAnswerDal = questionAnswerDal;
        }
        public void ToUpper(qa.QuestionAnswer questionAnswer)
        {
            questionAnswer.Answer = questionAnswer.Answer.ToUpper();
        }
        public void Trim(qa.QuestionAnswer questionAnswer)
        {
            questionAnswer.Answer = questionAnswer.Answer.Trim();
        }
    }
}
