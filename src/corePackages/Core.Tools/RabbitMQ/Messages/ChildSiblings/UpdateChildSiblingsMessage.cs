namespace Core.Tools.RabbitMQ.Messages.ChildSiblings
{
    public class UpdateChildSiblingsMessage
    {
        public string Id { get; set; }
        public string ChildId { get; set; }
        public string GenderId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string EducationStatusId { get; set; }
        public string Job { get; set; }
    }
}
