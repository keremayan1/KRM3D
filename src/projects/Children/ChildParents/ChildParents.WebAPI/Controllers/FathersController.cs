using ChildParents.Application.Features.Fathers.Commands.CreateFathers;
using ChildParents.Application.Features.Fathers.Commands.DeleteFathers;
using ChildParents.Application.Features.Fathers.Commands.UpdateFathers;
using ChildParents.Application.Features.Fathers.DTOs;
using Core.Shared.BaseController;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChildParents.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FathersController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateFathersCommand createFathersCommand)
        {
            CreatedFatherDto result = await Mediator.Send(createFathersCommand);
            return Created("", result);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateFathersCommand updateFathersCommand)
        {
            UpdatedFatherDto result = await Mediator.Send(updateFathersCommand);
            return Ok(result);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] DeleteFatherCommand deleteFathersCommand)
        {
            DeletedFathersDto result = await Mediator.Send(deleteFathersCommand);
            return Ok(result);
        }
    }
}
