﻿namespace Application.Features.AdultSiblings.Messages
{
    public class UpdateAdultSiblingsMessage
    {
        public string _id { get; set; }
        public string AdultId { get; set; }
        public string GenderId { get; set; }
        public string EducationStatusId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Job { get; set; }
        public string TelephoneNumber { get; set; }
        public string HowManyChildHave { get; set; }
        public string IsLiveWith { get; set; }
    }
}
