namespace Core.Tools.RabbitMQ.Messages.ChildParents.Mothers
{
    public class CreateChildMotherMessage
    {
        public string Id { get; set; }
        public string ChildrenId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EducationStatusId { get; set; }
        public string Job { get; set; }
        public string TelephoneNumber { get; set; }
    }
}
