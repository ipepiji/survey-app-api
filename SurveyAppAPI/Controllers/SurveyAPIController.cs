using Microsoft.AspNetCore.Mvc;
using SurveyAppAPI.Data;
using SurveyAppAPI.Models;

namespace SurveyAppAPI.Controllers
{
    [Route("api/v1/survey")]
    [ApiController]
    public class SurveyAPIController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<SurveyQuestions>> GetSurveys()
        {
            return Ok(SurveyQuestionsStore.surveyQuestionList);
        }

        [HttpGet("{id:int}", Name = "GetSurvey")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<SurveyQuestions> GetSurvey(int id)
        {
            var data = SurveyQuestionsStore.surveyQuestionList.FirstOrDefault(u => u.ID == id);
            if(data == null)
                return NotFound();

            return Ok(data);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<SurveyQuestions> CreateSurvey([FromBody]SurveyQuestions surveyQuestion) 
        {
            if (surveyQuestion == null)
                return BadRequest();

            surveyQuestion.ID = SurveyQuestionsStore.surveyQuestionList.OrderByDescending(u => u.ID).FirstOrDefault().ID + 1;
            SurveyQuestionsStore.surveyQuestionList.Add(surveyQuestion);   

            return CreatedAtRoute("GetSurvey", new { id = surveyQuestion.ID }, surveyQuestion);
        }

        [HttpDelete("{id:int}", Name = "DeleteSurvey")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult DeleteSurvey(int id)
        {
            var data = SurveyQuestionsStore.surveyQuestionList.FirstOrDefault(u => u.ID == id);
            if (data == null)
                return NotFound();

            SurveyQuestionsStore.surveyQuestionList.Remove(data);

            return NoContent();
        }

        [HttpPut("{id:int}", Name = "UpdateSurvey")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult UpdateSurvey(int id, [FromBody]SurveyQuestions surveyQuestion)
        {
            var data = SurveyQuestionsStore.surveyQuestionList.FirstOrDefault(u => u.ID == id);
            if (data == null)
                return NotFound();

            data.Question = surveyQuestion.Question;

            return NoContent();
        }
    }
}
