using System.ComponentModel.DataAnnotations;

namespace SurveyAppAPI.Models
{
    public class SurveyQuestions
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Question { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
