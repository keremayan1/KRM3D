namespace Application.Features.QuestionAnswer.Messages
{
    public class UpdateAdultQuestionAnswerMessage
    {
        public string _id { get; set; }
        public string QuestionId { get; set; }
        public string QuestionAnswer { get; set; }
    }
}
