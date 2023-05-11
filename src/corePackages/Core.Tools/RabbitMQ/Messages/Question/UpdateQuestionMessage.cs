namespace Core.Tools.RabbitMQ.Messages.Question
{
    public class UpdateQuestionMessage
    {
        public string _id { get; set; }
        public string QuestionTitleId { get; set; }
        public string QuestionName { get; set; }
    }

}
