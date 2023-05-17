using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configuration
{
    public class AdultQuestionConfiguration : IEntityTypeConfiguration<AdultQuestionModelView>
    {
        public void Configure(EntityTypeBuilder<AdultQuestionModelView> builder)
        {
            builder.ToTable("adult_question").HasKey(x => x._id);
            builder.Property(x => x._id).HasColumnName("id").ValueGeneratedNever();
            builder.Property(x => x.QuestionTitleId).HasColumnName("question_title_id");
            builder.Property(x => x.QuestionName).HasColumnName("question_name");

            builder.HasOne(x => x.AdultQuestionTitle).WithMany(x=>x.AdultQuestions).HasForeignKey(x=>x.QuestionTitleId);
            builder.HasMany(x => x.AdultQuestionAnswers);
        }
    }
}
