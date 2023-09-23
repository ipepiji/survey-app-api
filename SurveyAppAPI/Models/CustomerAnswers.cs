using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SurveyAppAPI.Models
{
    public class CustomerAnswers
    {
        [Required]
        public List<Answers> Survey { get; set; }
    }
}
