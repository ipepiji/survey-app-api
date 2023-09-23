using Microsoft.AspNetCore.Mvc;
using SurveyAppAPI.Data;
using SurveyAppAPI.Models;

namespace SurveyAppAPI.Controllers
{
    [Route("api/v1/survey/question")]
    [ApiController]
    public class SurveyQuestionAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public SurveyQuestionAPIController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<SurveyQuestions>> GetSurveyQuestions()
        {
            return Ok(_db.SurveyQuestions.ToList());
        }

        [HttpGet("{id:int}", Name = "GetSurveyQuestion")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<SurveyQuestions> GetSurveyQuestion(int id)
        {
            var data = _db.SurveyQuestions.FirstOrDefault(u => u.ID == id);
            if(data == null)
                return NotFound();

            return Ok(data);
        }

        [HttpPost(Name = "CreateSurveyQuestion")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<SurveyQuestions> CreateSurveyQuestion([FromBody]SurveyQuestions surveyQuestion) 
        {
            if (surveyQuestion == null)
                return BadRequest();

            SurveyQuestions model = new()
            {
                Question = surveyQuestion.Question
            };
            _db.SurveyQuestions.Add(model);
            _db.SaveChanges();

            return CreatedAtRoute("GetSurveyQuestion", new { id = surveyQuestion.ID }, surveyQuestion);
        }

        [HttpDelete("{id:int}", Name = "DeleteSurveyQuestion")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult DeleteSurveyQuestion(int id)
        {
            var data = _db.SurveyQuestions.FirstOrDefault(u => u.ID == id);
            if (data == null)
                return NotFound();

            _db.SurveyQuestions.Remove(data);
            _db.SaveChanges();

            return NoContent();
        }

        [HttpPut("{id:int}", Name = "UpdateSurveyQuestion")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult UpdateSurveyQuestion(int id, [FromBody]SurveyQuestions surveyQuestion)
        {
            var data = _db.SurveyQuestions.FirstOrDefault(u => u.ID == id);
            if (data == null)
                return NotFound();

            data.Question = surveyQuestion.Question;
            
            _db.SurveyQuestions.Update(data);
            _db.SaveChanges();

            return NoContent();
        }
    }
}
