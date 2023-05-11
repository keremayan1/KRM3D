using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configurations
{
    public class QuestionAnswerConfiguration : IEntityTypeConfiguration<QuestionAnswer>
    {
        public void Configure(EntityTypeBuilder<QuestionAnswer> builder)
        {
            builder.ToTable("QuestionAnswers").HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedNever();
            builder.Property(x => x.QuestionId).HasColumnName("QuestionId");
            builder.Property(x => x.ChildrenId).HasColumnName("ChildrenId");
            builder.Property(x => x.Answer).HasColumnName("Answer");
            builder.HasOne(x => x.Child).WithMany(x=>x.QuestionAnswers).HasForeignKey(x=>x.ChildrenId);
            builder.HasOne(x => x.Question);
        }
    }
}
