using Core.Shared.BaseController;
using Gender.Application.Features.Genders.Commands.CreateGender;
using Gender.Application.Features.Genders.Commands.DeleteGender;
using Gender.Application.Features.Genders.Commands.UpdateGender;
using Gender.Application.Features.Genders.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gender.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GendersController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateGenderCommand createGenderCommand)
        {
            CreatedGenderDto result = await Mediator.Send(createGenderCommand);
            return Created("", result);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateGenderCommand updateGenderCommand)
        {
            UpdatedGenderDto result = await Mediator.Send(updateGenderCommand);
            return Ok(result);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete ([FromQuery] DeleteGenderCommand deleteGenderCommand)
        {
            DeletedGenderDto result = await Mediator.Send(deleteGenderCommand);
            return Ok(result);
        }
    }
}
