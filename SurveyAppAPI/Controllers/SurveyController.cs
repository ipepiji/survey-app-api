using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Any;
using SurveyAppAPI.Data;
using SurveyAppAPI.Models;

namespace SurveyAppAPI.Controllers
{
    [Route("api/v1/survey")]
    [ApiController]
    public class SurveyController : Controller
    {
        private readonly ApplicationDbContext _db;

        public SurveyController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpPost(Name = "CreateSurvey")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<Surveys> CreateSurvey([FromBody] CustomerAnswers customerAnswer)
        {
            if (customerAnswer == null)
                return BadRequest();

            foreach (var survey in customerAnswer.Survey)
            {
                Surveys surveyModel = new()
                {
                    SubmitTime = survey.SubmitTime
                };
                _db.Surveys.Add(surveyModel);
                _db.SaveChanges();

                SurveysAnswers surveyAnswerModel = new()
                {
                    SurveysID = surveyModel.ID,
                    Answer = survey.Answer
                };
                _db.SurveysAnswers.Add(surveyAnswerModel);
                _db.SaveChanges();
            }

            return StatusCode(201);
        }
    }
}
