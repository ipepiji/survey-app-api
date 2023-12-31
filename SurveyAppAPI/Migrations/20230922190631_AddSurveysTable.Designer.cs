﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SurveyAppAPI.Data;

#nullable disable

namespace SurveyAppAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230922190631_AddSurveysTable")]
    partial class AddSurveysTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("SurveyQuestions");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedDate = new DateTime(2023, 9, 23, 3, 6, 31, 378, DateTimeKind.Local).AddTicks(5825),
                            Question = "Do you like bread?",
                            UpdatedDate = new DateTime(2023, 9, 23, 3, 6, 31, 378, DateTimeKind.Local).AddTicks(5839)
                        },
                        new
                        {
                            ID = 2,
                            CreatedDate = new DateTime(2023, 9, 23, 3, 6, 31, 378, DateTimeKind.Local).AddTicks(5840),
                            Question = "Which one?",
                            UpdatedDate = new DateTime(2023, 9, 23, 3, 6, 31, 378, DateTimeKind.Local).AddTicks(5841)
                        },
                        new
                        {
                            ID = 3,
                            CreatedDate = new DateTime(2023, 9, 23, 3, 6, 31, 378, DateTimeKind.Local).AddTicks(5842),
                            Question = "Which brand?",
                            UpdatedDate = new DateTime(2023, 9, 23, 3, 6, 31, 378, DateTimeKind.Local).AddTicks(5842)
                        });
                });

            modelBuilder.Entity("SurveyAppAPI.Models.Surveys", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SubmitTime")
                        .HasMaxLength(100)
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedDate")
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

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SurveysID")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("SurveyAnswers");
                });
#pragma warning restore 612, 618
        }
    }
}
