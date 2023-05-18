﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistance.Contexts;

#nullable disable

namespace Persistance.Migrations
{
    [DbContext(typeof(SQLContext))]
    partial class SQLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Domain.Entities.Child", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Id");

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ClassName");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2")
                        .HasColumnName("DateOfBirth");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FirstName");

                    b.Property<string>("GenderId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("GenderId");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LastName");

                    b.Property<string>("NationalId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NationalId");

                    b.Property<string>("SchoolName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("SchoolName");

                    b.HasKey("Id");

                    b.HasIndex("GenderId");

                    b.ToTable("Children", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.ChildFather", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Id");

                    b.Property<string>("ChildrenId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("ChildrenId");

                    b.Property<string>("EducationStatusId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("EducationStatusId");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FirstName");

                    b.Property<string>("Job")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Job");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LastName");

                    b.Property<string>("TelephoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TelephoneNumber");

                    b.HasKey("Id");

                    b.HasIndex("ChildrenId")
                        .IsUnique();

                    b.HasIndex("EducationStatusId");

                    b.ToTable("ChildFathers", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.ChildMother", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Id");

                    b.Property<string>("ChildrenId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("ChildrenId");

                    b.Property<string>("EducationStatusId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("EducationStatusId");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FirstName");

                    b.Property<string>("Job")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Job");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LastName");

                    b.Property<string>("TelephoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TelephoneNumber");

                    b.HasKey("Id");

                    b.HasIndex("ChildrenId")
                        .IsUnique();

                    b.HasIndex("EducationStatusId");

                    b.ToTable("ChildMothers", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.ChildSiblings", b =>
                {
                    b.Property<string>("_id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Id");

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Age");

                    b.Property<string>("ChildId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("ChildId");

                    b.Property<string>("EducationStatusId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("EducationStatusId");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FirstName");

                    b.Property<string>("GenderId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("GenderId");

                    b.Property<string>("Job")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Job");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LastName");

                    b.HasKey("_id");

                    b.HasIndex("ChildId");

                    b.HasIndex("EducationStatusId");

                    b.HasIndex("GenderId");

                    b.ToTable("ChildSiblings", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.EducationStatusReadModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Id");

                    b.Property<string>("EducationStatusName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("EducationStatusName");

                    b.HasKey("Id");

                    b.ToTable("EducationStatuses", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.GenderReadModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Id");

                    b.Property<string>("GenderName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("GenderName");

                    b.HasKey("Id");

                    b.ToTable("Genders", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Question", b =>
                {
                    b.Property<string>("_id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Id");

                    b.Property<string>("QuestionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("QuestionName");

                    b.Property<string>("QuestionTitleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("QuestionTitleId");

                    b.HasKey("_id");

                    b.HasIndex("QuestionTitleId");

                    b.ToTable("Questions", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.QuestionAnswer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Id");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Answer");

                    b.Property<string>("ChildrenId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("ChildrenId");

                    b.Property<string>("QuestionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("QuestionId");

                    b.HasKey("Id");

                    b.HasIndex("ChildrenId");

                    b.HasIndex("QuestionId");

                    b.ToTable("QuestionAnswers", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.QuestionTitle", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("Id");

                    b.Property<string>("QuestionTitleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("QuestionTitleName");

                    b.HasKey("Id");

                    b.ToTable("QuestionTitles", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Child", b =>
                {
                    b.HasOne("Domain.Entities.GenderReadModel", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("Domain.Entities.ChildFather", b =>
                {
                    b.HasOne("Domain.Entities.Child", "Child")
                        .WithOne("ChildFather")
                        .HasForeignKey("Domain.Entities.ChildFather", "ChildrenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.EducationStatusReadModel", "EducationStatus")
                        .WithMany()
                        .HasForeignKey("EducationStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Child");

                    b.Navigation("EducationStatus");
                });

            modelBuilder.Entity("Domain.Entities.ChildMother", b =>
                {
                    b.HasOne("Domain.Entities.Child", "Child")
                        .WithOne("ChildMother")
                        .HasForeignKey("Domain.Entities.ChildMother", "ChildrenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.EducationStatusReadModel", "EducationStatus")
                        .WithMany()
                        .HasForeignKey("EducationStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Child");

                    b.Navigation("EducationStatus");
                });

            modelBuilder.Entity("Domain.Entities.ChildSiblings", b =>
                {
                    b.HasOne("Domain.Entities.Child", "Child")
                        .WithMany("ChildSiblings")
                        .HasForeignKey("ChildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.EducationStatusReadModel", "EducationStatus")
                        .WithMany()
                        .HasForeignKey("EducationStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.GenderReadModel", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Child");

                    b.Navigation("EducationStatus");

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("Domain.Entities.Question", b =>
                {
                    b.HasOne("Domain.Entities.QuestionTitle", "QuestionTitle")
                        .WithMany("Questions")
                        .HasForeignKey("QuestionTitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QuestionTitle");
                });

            modelBuilder.Entity("Domain.Entities.QuestionAnswer", b =>
                {
                    b.HasOne("Domain.Entities.Child", "Child")
                        .WithMany("QuestionAnswers")
                        .HasForeignKey("ChildrenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Question", "Question")
                        .WithMany("QuestionAnswers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Child");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Domain.Entities.Child", b =>
                {
                    b.Navigation("ChildFather");

                    b.Navigation("ChildMother");

                    b.Navigation("ChildSiblings");

                    b.Navigation("QuestionAnswers");
                });

            modelBuilder.Entity("Domain.Entities.Question", b =>
                {
                    b.Navigation("QuestionAnswers");
                });

            modelBuilder.Entity("Domain.Entities.QuestionTitle", b =>
                {
                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
