using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configurations
{
    public class QuestionTitleConfiguration : IEntityTypeConfiguration<QuestionTitle>
    {
        public void Configure(EntityTypeBuilder<QuestionTitle> builder)
        {
            builder.ToTable("QuestionTitles").HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedNever();
            builder.Property(x => x.QuestionTitleName).HasColumnName("QuestionTitleName");
            builder.HasMany(x => x.Questions);
        }
    }
}
