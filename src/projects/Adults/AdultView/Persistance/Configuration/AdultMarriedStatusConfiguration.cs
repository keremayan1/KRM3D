using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configuration
{
    public class AdultMarriedStatusConfiguration : IEntityTypeConfiguration<AdultMarriedStatusModelView>
    {
        public void Configure(EntityTypeBuilder<AdultMarriedStatusModelView> builder)
        {
            builder.ToTable("adult_married_status").HasKey(x => x._id);
            builder.Property(x => x._id).HasColumnName("id").ValueGeneratedNever();
            builder.Property(x => x.MarriedStatusName).HasColumnName("married_status_name");
        }
    }
}
