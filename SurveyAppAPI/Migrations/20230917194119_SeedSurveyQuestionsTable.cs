using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SurveyAppAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedSurveyQuestionsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SurveyQuestions",
                columns: new[] { "ID", "Question" },
                values: new object[,]
                {
                    { 1, "Do you like bread?"},
                    { 2, "Which one?" },
                    { 3, "Which brand?"}
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SurveyQuestions",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
