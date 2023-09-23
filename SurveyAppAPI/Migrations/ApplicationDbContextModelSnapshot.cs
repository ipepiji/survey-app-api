﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SurveyAppAPI.Data;

#nullable disable

namespace SurveyAppAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SurveyAppAPI.Models.SurveyQuestions", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.ToTable("SurveyQuestions");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Question = "Do you like bread?",
                        },
                        new
                        {
                            ID = 2,
                            Question = "Which one?",
                        },
                        new
                        {
                            ID = 3,
                            Question = "Which brand?",
                        });
                });

            modelBuilder.Entity("SurveyAppAPI.Models.Surveys", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("SubmitTime")
                        .HasMaxLength(100)
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Surveys");
                });

            modelBuilder.Entity("SurveyAppAPI.Models.SurveysAnswers", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("SurveysID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("SurveysAnswers");
                });
#pragma warning restore 612, 618
        }
    }
}