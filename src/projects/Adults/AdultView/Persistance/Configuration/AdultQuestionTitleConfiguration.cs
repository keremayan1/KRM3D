using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configuration
{
    public class AdultQuestionTitleConfiguration : IEntityTypeConfiguration<AdultQuestionTitleModelView>
    {
        public void Configure(EntityTypeBuilder<AdultQuestionTitleModelView> builder)
        {
            builder.ToTable("adult_question_title").HasKey(x => x._id);
            builder.Property(x => x._id).HasColumnName("id").ValueGeneratedNever();
            builder.Property(x => x.QuestionTitleName).HasColumnName("question_title_name");
        }
    }
}
