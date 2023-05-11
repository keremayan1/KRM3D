using Core.Shared.BaseController;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuestionTitle.Application.Features.QuestionTitles.Commands.CreateQuestionTitle;
using QuestionTitle.Application.Features.QuestionTitles.Commands.DeleteQuestionTitle;
using QuestionTitle.Application.Features.QuestionTitles.Commands.UpdateQuestionTitle;
using QuestionTitle.Application.Features.QuestionTitles.Dtos;

namespace QuestionTitle.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QuestionTitlesController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateQuestionTitleCommand createQuestionTitleCommand)
        {
            CreatedQuestionTitleDto result = await Mediator.Send(createQuestionTitleCommand);
            return Created("", result);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] DeleteQuestionTitleCommand deleteQuestionTitleCommand)
        {
            DeletedQuestionTitleDto result = await Mediator.Send(deleteQuestionTitleCommand);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateQuestionTitleCommand updateQuestionTitleCommand)
        {
            UpdatedQuestionTitleDto result = await Mediator.Send(updateQuestionTitleCommand);
            return Ok(result);
        }
    }
}
