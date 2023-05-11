﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configurations
{
    public class ChildFatherConfiguration : IEntityTypeConfiguration<ChildFather>
    {
        public void Configure(EntityTypeBuilder<ChildFather> builder)
        {
            builder.ToTable("ChildFathers").HasKey(p => p.Id);
            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedNever();
            builder.Property(x => x.ChildrenId).HasColumnName("ChildrenId");
            builder.Property(x => x.FirstName).HasColumnName("FirstName");
            builder.Property(x => x.LastName).HasColumnName("LastName");
            builder.Property(x => x.EducationStatusId).HasColumnName("EducationStatusId");
            builder.Property(x => x.Job).HasColumnName("Job");
            builder.Property(x => x.TelephoneNumber).HasColumnName("TelephoneNumber");
            builder.HasOne(x => x.Child).WithOne(x=>x.ChildFather);
            
        }
    }
}
