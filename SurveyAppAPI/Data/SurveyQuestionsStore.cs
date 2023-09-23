using SurveyAppAPI.Models;
using System.Net.NetworkInformation;

namespace SurveyAppAPI.Data
{
    public static class SurveyQuestionsStore
    {
        public static List<SurveyQuestions> surveyQuestionList = new List<SurveyQuestions> {
            new SurveyQuestions { ID = 1, Question = "Do you like bread?"},
            new SurveyQuestions { ID = 2, Question = "Which one?" },
            new SurveyQuestions { ID = 3, Question = "Which brand?"}
            };
    }
}
