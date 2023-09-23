using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SurveyAppAPI.Models
{
    public class SurveysAnswers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [ForeignKey("Surveys")]
        public int SurveysID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Answer { get; set; }
    }
}
