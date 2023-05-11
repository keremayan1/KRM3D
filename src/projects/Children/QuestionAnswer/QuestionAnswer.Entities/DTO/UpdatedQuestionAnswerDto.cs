namespace QuestionAnswer.Business.DTO
{
    public class UpdatedQuestionAnswerDto
    {
        public string Id { get; set; }
        public string QuestionId { get; set; }
        public string ChildrenId { get; set; }
        public string Answer { get; set; }
    }
}
