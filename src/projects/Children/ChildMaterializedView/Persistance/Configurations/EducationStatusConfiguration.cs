using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Configurations
{
    public class EducationStatusConfiguration : IEntityTypeConfiguration<EducationStatusReadModel>
    {
        public void Configure(EntityTypeBuilder<EducationStatusReadModel> builder)
        {
            builder.ToTable("EducationStatuses").HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedNever();
            builder.Property(x => x.EducationStatusName).HasColumnName("EducationStatusName");
        }
    }
}
