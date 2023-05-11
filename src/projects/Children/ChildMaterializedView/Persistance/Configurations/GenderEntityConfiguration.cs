using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Configurations
{
    public class GenderEntityConfiguration : IEntityTypeConfiguration<GenderReadModel>
    {
        public void Configure(EntityTypeBuilder<GenderReadModel> builder)
        {
            builder.ToTable("Genders").HasKey(x => x.Id);
            builder.Property(p => p.Id).HasColumnName("Id").ValueGeneratedNever();
            builder.Property(p => p.GenderName).HasColumnName("GenderName");
        }
    }
}
