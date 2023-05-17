using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configuration
{
    public class AdultQuestionAnswerConfiguration : IEntityTypeConfiguration<AdultQuestionAnswerModelView>
    {
        public void Configure(EntityTypeBuilder<AdultQuestionAnswerModelView> builder)
        {
            builder.ToTable("adult_question_answer").HasKey(x => x._id);
            builder.Property(x => x._id).HasColumnName("id").ValueGeneratedNever();
            builder.Property(x => x.AdultId).HasColumnName("adult_id");
            builder.Property(x => x.QuestionId).HasColumnName("question_id");
            builder.Property(x => x.QuestionAnswer).HasColumnName("question_answer");

            builder.HasOne(x => x.Adult).WithMany(x => x.AdultQuestionAnswers).HasForeignKey(x => x.AdultId);
            builder.HasOne(x => x.AdultQuestion).WithMany(x=>x.AdultQuestionAnswers).HasForeignKey(x=>x.QuestionId);
        }
    }
}
