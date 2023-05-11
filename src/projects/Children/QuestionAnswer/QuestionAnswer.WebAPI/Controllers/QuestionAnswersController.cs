using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuestionAnswer.Business.Abstracts;
using QuestionAnswer.Business.DTO;

namespace QuestionAnswer.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QuestionAnswersController : ControllerBase
    {
        private readonly IQuestionAnswerService _questionAnswerService;

        public QuestionAnswersController(IQuestionAnswerService questionAnswerService)
        {
            _questionAnswerService = questionAnswerService;
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] List<CreatedQuestionAnswerDto> createdQuestionAnswerDto)
        {
            var result = await _questionAnswerService.AddAll(createdQuestionAnswerDto);
            return Created("", result);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] string id)
        {
            var result = await _questionAnswerService.Delete(id);
            return Ok( result);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdatedQuestionAnswerDto updatedQuestionAnswerDto)
        {
            var result = await _questionAnswerService.Update(updatedQuestionAnswerDto);
            return Ok(result);
        }
    }
}
