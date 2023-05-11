using ChildParents.Application.Features.Mothers.Commands.CreatedMothers;
using ChildParents.Application.Features.Mothers.Commands.DeletedMothers;
using ChildParents.Application.Features.Mothers.Commands.UpdatedMothers;
using ChildParents.Application.Features.Mothers.DTOs;
using Core.Shared.BaseController;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChildParents.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MothersController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateMotherCommand createdMotherCommand)
        {
            CreatedMotherDto result = await Mediator.Send(createdMotherCommand);
            return Created("",result);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] DeleteMothersCommand deleteMothersCommand)
        {
            DeletedMotherDto result = await Mediator.Send(deleteMothersCommand);
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateMotherCommand updateMotherCommand)
        {
            UpdatedMotherDto result = await Mediator.Send(updateMotherCommand);
            return Ok(result);
        }
    }
}
