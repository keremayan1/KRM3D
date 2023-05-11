using Child.Application.Features.Children.Commands.CreateChild;
using Child.Application.Features.Children.Commands.DeleteChild;
using Child.Application.Features.Children.Commands.UpdateChild;
using Child.Application.Features.Children.Dtos;
using Core.Shared.BaseController;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Child.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ChildrenController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateChildCommand createChildCommand)
        {
            CreatedChildDto result = await Mediator.Send(createChildCommand);
            return Created("", result);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateChildCommand updateChildCommand)
        {
            UpdatedChildDto result = await Mediator.Send(updateChildCommand);
            return Ok(result);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] DeleteChildCommand deleteChildCommand)
        {
            DeletedChildDto result = await Mediator.Send(deleteChildCommand);
            return Ok(result);
        }
    }
}
