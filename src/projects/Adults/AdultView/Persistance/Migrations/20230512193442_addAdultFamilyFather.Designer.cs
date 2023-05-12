﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistance.Contexts;

#nullable disable

namespace Persistance.Migrations
{
    [DbContext(typeof(MySQLContext))]
    [Migration("20230512193442_addAdultFamilyFather")]
    partial class addAdultFamilyFather
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("age");

                    b.Property<string>("EducationStatusId")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("education_status_id");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("first_name");

                    b.Property<string>("HowManyChildrenHave")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("how_many_children_have");

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
                        .HasColumnType("longtext")
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
                        .HasColumnType("longtext")
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

                    b.ToTable("adults", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.AdultQuestionAnswerModelView", b =>
                {
                    b.Property<string>("_id")
                        .HasColumnType("varchar(255)")
                        .HasColumnName("id");

                    b.Property<string>("QuestionAnswer")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("question_answer");

                    b.Property<string>("QuestionId")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("question_id");

                    b.HasKey("_id");

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
                        .HasColumnType("longtext")
                        .HasColumnName("question_title_id");

                    b.HasKey("_id");

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

            modelBuilder.Entity("Domain.Entities.AdultModelView", b =>
                {
                    b.HasOne("Domain.Entities.AdultEducationStatusModelView", "EducationStatus")
                        .WithMany()
                        .HasForeignKey("EducationStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EducationStatus");
                });
#pragma warning restore 612, 618
        }
    }
}