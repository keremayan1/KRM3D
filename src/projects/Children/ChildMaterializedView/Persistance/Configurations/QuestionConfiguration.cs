using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configurations
{
    public class QuestionConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.ToTable("Questions").HasKey(x => x._id);
            builder.Property(x => x._id).HasColumnName("Id").ValueGeneratedNever();
            builder.Property(x => x.QuestionTitleId).HasColumnName("QuestionTitleId");
            builder.Property(x => x.QuestionName).HasColumnName("QuestionName");
            builder.HasOne(x => x.QuestionTitle);
            builder.HasMany(x => x.QuestionAnswers);
        }
    }
}
