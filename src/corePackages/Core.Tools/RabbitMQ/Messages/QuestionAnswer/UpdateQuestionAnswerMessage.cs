namespace Core.Tools.RabbitMQ.Messages.QuestionAnswer
{
    public class UpdateQuestionAnswerMessage
    {
        public string Id { get; set; }
        public string QuestionId { get; set; }
        public string ChildrenId { get; set; }
        public string Answer { get; set; }
    }
}
