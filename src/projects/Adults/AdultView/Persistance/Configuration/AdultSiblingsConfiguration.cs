using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configuration
{
    public class AdultSiblingsConfiguration : IEntityTypeConfiguration<AdultSiblingsModelView>
    {
        public void Configure(EntityTypeBuilder<AdultSiblingsModelView> builder)
        {
            builder.ToTable("adult_siblings").HasKey(x => x._id);
            builder.Property(x => x._id).HasColumnName("id").ValueGeneratedNever();
            builder.Property(x => x.EducationStatusId).HasColumnName("education_status_id");
            builder.Property(x => x.GenderId).HasColumnName("gender_id");
            builder.Property(x => x.FirstName).HasColumnName("first_name");
            builder.Property(x => x.LastName).HasColumnName("last_name");
            builder.Property(x => x.Age).HasColumnName("age");
            builder.Property(x => x.TelephoneNumber).HasColumnName("telephone_number");
            builder.Property(x => x.Job).HasColumnName("job");
            builder.Property(x => x.HowManyChildHave).HasColumnName("how_many_child_have");
            builder.Property(x => x.IsLiveWith).HasColumnName("is_live_with");
        }
    }
}
