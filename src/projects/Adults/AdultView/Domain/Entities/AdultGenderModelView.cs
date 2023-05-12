using Core.Persistance.Repositories.EntityFramework;

namespace Domain.Entities
{
    public class AdultGenderModelView : Entity
    {
        public string Id { get; set; }
        public string GenderName { get; set; }

        public AdultGenderModelView(string id, string genderName) : this()
        {
            Id = id;
            GenderName = genderName;
        }

        public AdultGenderModelView()
        {

        }
    }
}
