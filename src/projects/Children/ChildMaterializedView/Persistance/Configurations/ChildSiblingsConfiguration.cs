using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configurations
{
    public class ChildSiblingsConfiguration : IEntityTypeConfiguration<ChildSiblings>
    {
        public void Configure(EntityTypeBuilder<ChildSiblings> builder)
        {
            builder.ToTable("ChildSiblings").HasKey(p => p._id);
            builder.Property(x => x._id).HasColumnName("Id").ValueGeneratedNever();
            builder.Property(x => x.ChildId).HasColumnName("ChildId");
            builder.Property(x => x.GenderId).HasColumnName("GenderId");
            builder.Property(x => x.FirstName).HasColumnName("FirstName");
            builder.Property(x => x.LastName).HasColumnName("LastName");
            builder.Property(x => x.Age).HasColumnName("Age");
            builder.Property(x => x.EducationStatusId).HasColumnName("EducationStatusId");
            builder.Property(x => x.Job).HasColumnName("Job");
            builder.HasOne(x => x.Child);
            builder.HasOne(x => x.EducationStatus);
            builder.HasOne(x => x.Gender).WithMany().OnDelete(DeleteBehavior.NoAction);
            
           
        }
    }
}
