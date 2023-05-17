﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistance.Contexts;

#nullable disable

namespace Persistance.Migrations
{
    [DbContext(typeof(MySQLContext))]
    partial class MySQLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.AdultEducationStatusModelView", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("id");

                    b.Property<string>("EducationStatusName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("education_status_name");

                    b.HasKey("Id");

                    b.ToTable("adult_education_status", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.AdultFatherModelView", b =>
                {
                    b.Property<string>("_id")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("id");

                    b.Property<string>("AdultId")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("adult_id");

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("age");

                    b.Property<string>("EducationStatusId")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("education_status_id");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("first_name");

                    b.Property<string>("HowManyChildHave")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("how_many_child_have");

                    b.Property<string>("IsLiveWith")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("is_live_with");

                    b.Property<string>("Job")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("job");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("last_name");

                    b.Property<string>("TelephoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("telephone_number");

                    b.HasKey("_id");

                    b.HasIndex("AdultId")
                        .IsUnique();

                    b.HasIndex("EducationStatusId");

                    b.ToTable("adult_father", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.AdultGenderModelView", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("id");

                    b.Property<string>("GenderName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("gender_name");

                    b.HasKey("Id");

                    b.ToTable("adult_gender", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.AdultMarriedStatusModelView", b =>
                {
                    b.Property<string>("_id")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("id");

                    b.Property<string>("MarriedStatusName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("married_status_name");

                    b.HasKey("_id");

                    b.ToTable("adult_married_status", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.AdultModelView", b =>
                {
                    b.Property<string>("_id")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("id");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date_of_birth");

                    b.Property<string>("DidSheHeComeWith")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("did_she_he_come_with");

                    b.Property<string>("EducationStatusId")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("education_status_id");

                    b.Property<string>("EthnicName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("ethnic_name");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("first_name");

                    b.Property<string>("GenderId")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("gender_id");

                    b.Property<string>("IsLiveWith")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("is_live_with");

                    b.Property<string>("Job")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("job");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("last_name");

                    b.Property<string>("MarriedStatusId")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("married_status_id");

                    b.Property<string>("NationalId")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("national_id");

                    b.Property<string>("PersonComesFromHere")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("person_comes_from_here");

                    b.Property<string>("ReasonOfApplication")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("reason_of_application");

                    b.Property<string>("ReligionName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("religion_name");

                    b.HasKey("_id");

                    b.HasIndex("EducationStatusId");

                    b.HasIndex("GenderId");

                    b.HasIndex("MarriedStatusId");

                    b.ToTable("adults", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.AdultMotherModelView", b =>
                {
                    b.Property<string>("_id")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("id");

                    b.Property<string>("AdultId")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("adult_id");

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("age");

                    b.Property<string>("EducationStatusId")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("education_status_id");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("first_name");

                    b.Property<string>("HowManyChildHave")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("how_many_child_have");

                    b.Property<string>("IsLiveWith")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("is_live_with");

                    b.Property<string>("Job")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("job");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("last_name");

                    b.Property<string>("TelephoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("telephone_number");

                    b.HasKey("_id");

                    b.HasIndex("AdultId")
                        .IsUnique();

                    b.HasIndex("EducationStatusId");

                    b.ToTable("adult_mother", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.AdultQuestionAnswerModelView", b =>
                {
                    b.Property<string>("_id")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("id");

                    b.Property<string>("AdultId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("QuestionAnswer")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("question_answer");

                    b.Property<string>("QuestionId")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("question_id");

                    b.HasKey("_id");

                    b.HasIndex("AdultId");

                    b.HasIndex("QuestionId");

                    b.ToTable("adult_question_answer", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.AdultQuestionModelView", b =>
                {
                    b.Property<string>("_id")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("id");

                    b.Property<string>("QuestionName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("question_name");

                    b.Property<string>("QuestionTitleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("question_title_id");

                    b.HasKey("_id");

                    b.HasIndex("QuestionTitleId");

                    b.ToTable("adult_question", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.AdultQuestionTitleModelView", b =>
                {
                    b.Property<string>("_id")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("id");

                    b.Property<string>("QuestionTitleName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("question_title_name");

                    b.HasKey("_id");

                    b.ToTable("adult_question_title", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.AdultSiblingsModelView", b =>
                {
                    b.Property<string>("_id")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("id");

                    b.Property<string>("AdultId")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("adult_id");

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("age");

                    b.Property<string>("EducationStatusId")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("education_status_id");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("first_name");

                    b.Property<string>("GenderId")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("gender_id");

                    b.Property<string>("HowManyChildHave")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("how_many_child_have");

                    b.Property<string>("IsLiveWith")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("is_live_with");

                    b.Property<string>("Job")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("job");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("last_name");

                    b.Property<string>("TelephoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("telephone_number");

                    b.HasKey("_id");

                    b.HasIndex("AdultId");

                    b.HasIndex("EducationStatusId");

                    b.HasIndex("GenderId");

                    b.ToTable("adult_siblings", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.AdultFatherModelView", b =>
                {
                    b.HasOne("Domain.Entities.AdultModelView", "Adult")
                        .WithOne("AdultFather")
                        .HasForeignKey("Domain.Entities.AdultFatherModelView", "AdultId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AdultEducationStatusModelView", "AdultEducationStatus")
                        .WithMany()
                        .HasForeignKey("EducationStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adult");

                    b.Navigation("AdultEducationStatus");
                });

            modelBuilder.Entity("Domain.Entities.AdultModelView", b =>
                {
                    b.HasOne("Domain.Entities.AdultEducationStatusModelView", "EducationStatus")
                        .WithMany()
                        .HasForeignKey("EducationStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AdultGenderModelView", "AdultGender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AdultMarriedStatusModelView", "AdultMarriedStatus")
                        .WithMany()
                        .HasForeignKey("MarriedStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdultGender");

                    b.Navigation("AdultMarriedStatus");

                    b.Navigation("EducationStatus");
                });

            modelBuilder.Entity("Domain.Entities.AdultMotherModelView", b =>
                {
                    b.HasOne("Domain.Entities.AdultModelView", "Adult")
                        .WithOne("AdultMother")
                        .HasForeignKey("Domain.Entities.AdultMotherModelView", "AdultId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AdultEducationStatusModelView", "AdultEducationStatus")
                        .WithMany()
                        .HasForeignKey("EducationStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adult");

                    b.Navigation("AdultEducationStatus");
                });

            modelBuilder.Entity("Domain.Entities.AdultQuestionAnswerModelView", b =>
                {
                    b.HasOne("Domain.Entities.AdultModelView", "Adult")
                        .WithMany("AdultQuestionAnswers")
                        .HasForeignKey("AdultId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AdultQuestionModelView", "AdultQuestion")
                        .WithMany("AdultQuestionAnswers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adult");

                    b.Navigation("AdultQuestion");
                });

            modelBuilder.Entity("Domain.Entities.AdultQuestionModelView", b =>
                {
                    b.HasOne("Domain.Entities.AdultQuestionTitleModelView", "AdultQuestionTitle")
                        .WithMany("AdultQuestions")
                        .HasForeignKey("QuestionTitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdultQuestionTitle");
                });

            modelBuilder.Entity("Domain.Entities.AdultSiblingsModelView", b =>
                {
                    b.HasOne("Domain.Entities.AdultModelView", "Adult")
                        .WithMany("AdultSiblings")
                        .HasForeignKey("AdultId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AdultEducationStatusModelView", "AdultEducationStatus")
                        .WithMany()
                        .HasForeignKey("EducationStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AdultGenderModelView", "AdultGender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Adult");

                    b.Navigation("AdultEducationStatus");

                    b.Navigation("AdultGender");
                });

            modelBuilder.Entity("Domain.Entities.AdultModelView", b =>
                {
                    b.Navigation("AdultFather");

                    b.Navigation("AdultMother");

                    b.Navigation("AdultQuestionAnswers");

                    b.Navigation("AdultSiblings");
                });

            modelBuilder.Entity("Domain.Entities.AdultQuestionModelView", b =>
                {
                    b.Navigation("AdultQuestionAnswers");
                });

            modelBuilder.Entity("Domain.Entities.AdultQuestionTitleModelView", b =>
                {
                    b.Navigation("AdultQuestions");
                });
#pragma warning restore 612, 618
        }
    }
}
