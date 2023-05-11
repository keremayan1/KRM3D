using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography.X509Certificates;

namespace Persistance.Configurations
{
    public class ChildConfiguration : IEntityTypeConfiguration<Child>
    {
        public void Configure(EntityTypeBuilder<Child> builder)
        {
            builder.ToTable("Children").HasKey(p => p.Id);
            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedNever();
            builder.Property(x => x.GenderId).HasColumnName("GenderId");
            builder.Property(x => x.NationalId).HasColumnName("NationalId");
            builder.Property(x => x.FirstName).HasColumnName("FirstName");
            builder.Property(x => x.LastName).HasColumnName("LastName");
            builder.Property(x => x.DateOfBirth).HasColumnName("DateOfBirth");
            builder.Property(x => x.SchoolName).HasColumnName("SchoolName");
            builder.Property(x => x.ClassName).HasColumnName("ClassName");
            builder.HasOne(x => x.Gender);
            builder.HasOne(x => x.ChildFather).WithOne(x=>x.Child).HasForeignKey<ChildFather>(x=>x.ChildrenId);
            builder.HasOne(x => x.ChildMother).WithOne(x => x.Child).HasForeignKey<ChildMother>(x => x.ChildrenId);
            builder.HasMany(x => x.ChildSiblings);
            builder.HasMany(x => x.QuestionAnswers);
           
        }
    }
}
