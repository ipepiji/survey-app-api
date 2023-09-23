using Microsoft.EntityFrameworkCore;
using SurveyAppAPI.Models;

namespace SurveyAppAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) 
        {

        }
        public DbSet<SurveysAnswers> SurveysAnswers { get; set; }

        public DbSet<Surveys> Surveys { get; set; }

        public DbSet<SurveyQuestions> SurveyQuestions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SurveyQuestions>().HasData(
            new SurveyQuestions { ID = 1, Question = "Do you like bread?"},
            new SurveyQuestions { ID = 2, Question = "Which one?" },
            new SurveyQuestions { ID = 3, Question = "Which brand?" }
            );
        }
    }
}
