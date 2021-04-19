﻿// <auto-generated />
using System;
using DataLayer.EfClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataLayer.Migrations
{
    [DbContext(typeof(TecContext))]
    [Migration("20200327164735_TEC")]
    partial class TEC
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataLayer.EfClasses.Candidate", b =>
                {
                    b.Property<string>("CandidateNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CandidateAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CandidateAge")
                        .HasColumnType("int");

                    b.Property<DateTime>("CandidateBirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CandidateContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CandidateEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CandidateFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CandidateFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CandidateGender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CandidateLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CandidateMiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("CandidateNumber");

                    b.ToTable("Candidate");
                });

            modelBuilder.Entity("DataLayer.EfClasses.Certification", b =>
                {
                    b.Property<string>("CertificationId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CandidateNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CertificationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("QualificationId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CertificationId");

                    b.HasIndex("CandidateNumber");

                    b.HasIndex("QualificationId");

                    b.ToTable("Certification");
                });

            modelBuilder.Entity("DataLayer.EfClasses.Company", b =>
                {
                    b.Property<string>("CompanyId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CompanyAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("CompanyId");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("DataLayer.EfClasses.Course", b =>
                {
                    b.Property<string>("CourseId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CourseDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CourseHours")
                        .HasColumnType("float");

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("CourseId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("DataLayer.EfClasses.Day", b =>
                {
                    b.Property<string>("DayId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Acronym")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DayName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DayId");

                    b.ToTable("Day");
                });

            modelBuilder.Entity("DataLayer.EfClasses.JobHistory", b =>
                {
                    b.Property<string>("HistoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CandidateNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CompanyId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("WorkedFrom")
                        .HasColumnType("datetime2");

                    b.Property<double?>("WorkedHours")
                        .HasColumnType("float");

                    b.Property<DateTime?>("WorkedTo")
                        .HasColumnType("datetime2");

                    b.HasKey("HistoryId");

                    b.HasIndex("CandidateNumber");

                    b.HasIndex("CompanyId");

                    b.ToTable("JobHistory");
                });

            modelBuilder.Entity("DataLayer.EfClasses.Opening", b =>
                {
                    b.Property<string>("OpeningNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("AnticipatedEndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CompanyId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("HourlyPay")
                        .HasColumnType("float");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("QualificationId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("StartingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("OpeningNumber");

                    b.HasIndex("CompanyId");

                    b.HasIndex("QualificationId");

                    b.ToTable("Opening");
                });

            modelBuilder.Entity("DataLayer.EfClasses.Placement", b =>
                {
                    b.Property<string>("PlacementId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CandidateNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("OpeningNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PlacementStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlacementId");

                    b.HasIndex("CandidateNumber");

                    b.HasIndex("OpeningNumber");

                    b.ToTable("Placement");
                });

            modelBuilder.Entity("DataLayer.EfClasses.Prerequisite", b =>
                {
                    b.Property<string>("PrerequisiteId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CourseId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("QualificationId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RequirementFor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PrerequisiteId");

                    b.HasIndex("CourseId");

                    b.HasIndex("QualificationId");

                    b.ToTable("Prerequisite");
                });

            modelBuilder.Entity("DataLayer.EfClasses.Qualification", b =>
                {
                    b.Property<string>("QualificationId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("QualificationCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QualificationId");

                    b.ToTable("Qualification");
                });

            modelBuilder.Entity("DataLayer.EfClasses.RegisteredCandidate", b =>
                {
                    b.Property<string>("RegistrationId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CandidateNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("RegisteredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SessionId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("RegistrationId");

                    b.HasIndex("CandidateNumber");

                    b.HasIndex("SessionId");

                    b.ToTable("RegisteredCandidate");
                });

            modelBuilder.Entity("DataLayer.EfClasses.Schedule", b =>
                {
                    b.Property<string>("ScheduleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DayId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("SessionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ScheduleId");

                    b.HasIndex("DayId");

                    b.HasIndex("SessionId");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("DataLayer.EfClasses.TrainingSession", b =>
                {
                    b.Property<string>("SessionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CourseId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<long>("SessionCapacity")
                        .HasColumnType("bigint");

                    b.Property<double>("SessionFee")
                        .HasColumnType("float");

                    b.HasKey("SessionId");

                    b.HasIndex("CourseId");

                    b.ToTable("TrainingSession");
                });

            modelBuilder.Entity("DataLayer.EfClasses.Certification", b =>
                {
                    b.HasOne("DataLayer.EfClasses.Candidate", "CandidateLink")
                        .WithMany("Certifications")
                        .HasForeignKey("CandidateNumber");

                    b.HasOne("DataLayer.EfClasses.Qualification", "QualificationLink")
                        .WithMany("Certifications")
                        .HasForeignKey("QualificationId");
                });

            modelBuilder.Entity("DataLayer.EfClasses.JobHistory", b =>
                {
                    b.HasOne("DataLayer.EfClasses.Candidate", "CandidateLink")
                        .WithMany("JobHistories")
                        .HasForeignKey("CandidateNumber");

                    b.HasOne("DataLayer.EfClasses.Company", "CompanyLink")
                        .WithMany("JobHistories")
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("DataLayer.EfClasses.Opening", b =>
                {
                    b.HasOne("DataLayer.EfClasses.Company", "CompanyLink")
                        .WithMany("Openings")
                        .HasForeignKey("CompanyId");

                    b.HasOne("DataLayer.EfClasses.Qualification", "QualificationLink")
                        .WithMany("Openings")
                        .HasForeignKey("QualificationId");
                });

            modelBuilder.Entity("DataLayer.EfClasses.Placement", b =>
                {
                    b.HasOne("DataLayer.EfClasses.Candidate", "CandidateLink")
                        .WithMany("Placements")
                        .HasForeignKey("CandidateNumber");

                    b.HasOne("DataLayer.EfClasses.Opening", "OpeningLink")
                        .WithMany("Placements")
                        .HasForeignKey("OpeningNumber");
                });

            modelBuilder.Entity("DataLayer.EfClasses.Prerequisite", b =>
                {
                    b.HasOne("DataLayer.EfClasses.Course", "CourseLink")
                        .WithMany("Prerequisites")
                        .HasForeignKey("CourseId");

                    b.HasOne("DataLayer.EfClasses.Qualification", "QualificationLink")
                        .WithMany("Prerequisites")
                        .HasForeignKey("QualificationId");
                });

            modelBuilder.Entity("DataLayer.EfClasses.RegisteredCandidate", b =>
                {
                    b.HasOne("DataLayer.EfClasses.Candidate", "CandidateLink")
                        .WithMany("RegisteredCandidates")
                        .HasForeignKey("CandidateNumber");

                    b.HasOne("DataLayer.EfClasses.TrainingSession", "TrainingSessionLink")
                        .WithMany("RegisteredCandidates")
                        .HasForeignKey("SessionId");
                });

            modelBuilder.Entity("DataLayer.EfClasses.Schedule", b =>
                {
                    b.HasOne("DataLayer.EfClasses.Day", "DayLink")
                        .WithMany("Schedules")
                        .HasForeignKey("DayId");

                    b.HasOne("DataLayer.EfClasses.TrainingSession", "TrainingSessionLink")
                        .WithMany("Schedules")
                        .HasForeignKey("SessionId");
                });

            modelBuilder.Entity("DataLayer.EfClasses.TrainingSession", b =>
                {
                    b.HasOne("DataLayer.EfClasses.Course", "CourseLink")
                        .WithMany("TrainingSessions")
                        .HasForeignKey("CourseId");
                });
#pragma warning restore 612, 618
        }
    }
}
