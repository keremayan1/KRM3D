using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configuration
{
    public class AdultEducationStatusConfiguration : IEntityTypeConfiguration<AdultEducationStatusModelView>
    {
        public void Configure(EntityTypeBuilder<AdultEducationStatusModelView> builder)
        {
            builder.ToTable("adult_education_status").HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedNever();
            builder.Property(x => x.EducationStatusName).HasColumnName("education_status_name");
        }
    }
}
