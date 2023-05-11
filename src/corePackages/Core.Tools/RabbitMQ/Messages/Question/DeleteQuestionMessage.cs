namespace Core.Tools.RabbitMQ.Messages.Question
{
    public class DeleteQuestionMessage
    {
        public string QuestionId { get; set; }
        public string QuestionTitleId { get; set; }
        public string QuestionName { get; set; }
    }

}
