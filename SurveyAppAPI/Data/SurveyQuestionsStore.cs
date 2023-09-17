using SurveyAppAPI.Models;
using System.Net.NetworkInformation;

namespace SurveyAppAPI.Data
{
    public static class SurveyQuestionsStore
    {
        public static List<SurveyQuestions> surveyQuestionList = new List<SurveyQuestions> {
            new SurveyQuestions { ID = 1, Question = "Question 1" },
            new SurveyQuestions { ID = 2, Question = "Question 2" }
            };
    }
}
