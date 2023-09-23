using System.ComponentModel.DataAnnotations;

namespace SurveyAppAPI.Models
{
    public class Answers
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Question { get; set; }
        [Required]
        [MaxLength(100)]
        public string Answer { get; set; }
        public DateTime SubmitTime { get; set; }
    }
}
