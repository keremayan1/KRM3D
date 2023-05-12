using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Configuration
{
    public class AdultConfiguration : IEntityTypeConfiguration<AdultModelView>
    {
        public void Configure(EntityTypeBuilder<AdultModelView> builder)
        {
            builder.ToTable("adults").HasKey(x => x._id);
            builder.Property(x => x._id).HasColumnName("id").ValueGeneratedNever();
            builder.Property(x => x.GenderId).HasColumnName("gender_id");
            builder.Property(x => x.EducationStatusId).HasColumnName("education_status_id");
            builder.Property(x => x.MarriedStatusId).HasColumnName("married_status_id");
            builder.Property(x => x.NationalId).HasColumnName("national_id");
            builder.Property(x => x.FirstName).HasColumnName("first_name");
            builder.Property(x => x.LastName).HasColumnName("last_name");
            builder.Property(x => x.DateOfBirth).HasColumnName("date_of_birth");
            builder.Property(x => x.EthnicName).HasColumnName("ethnic_name");
            builder.Property(x => x.ReligionName).HasColumnName("religion_name");
            builder.Property(x => x.Job).HasColumnName("job");
            builder.Property(x => x.IsLiveWith).HasColumnName("is_live_with");
            builder.Property(x => x.DidSheHeComeWith).HasColumnName("did_she_he_come_with");
            builder.Property(x => x.PersonComesFromHere).HasColumnName("person_comes_from_here");
            builder.Property(x => x.ReasonOfApplication).HasColumnName("reason_of_application");

            builder.HasOne(x => x.EducationStatus).WithOne().HasForeignKey<AdultModelView>(x=>x.EducationStatusId);
            
        }
    }
}
