using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configuration
{
    public class AdultGenderConfiguration : IEntityTypeConfiguration<AdultGenderModelView>
    {
        public void Configure(EntityTypeBuilder<AdultGenderModelView> builder)
        {
            builder.ToTable("adult_gender").HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedNever();
            builder.Property(x => x.GenderName).HasColumnName("gender_name");
        }
    }
}
