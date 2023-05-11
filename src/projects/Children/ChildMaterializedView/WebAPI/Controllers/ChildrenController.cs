using Application.Features.Children.Models;
using Application.Features.Children.Query.GetByChildId;
using Application.Features.Children.Query.GetListChild;
using Core.Application.Requests;
using Core.Shared.BaseController;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ChildrenController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            ChildModel result = await Mediator.Send(new GetListChildQuery { PageRequest = pageRequest });
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] string id)
        {
            ChildModel result = await Mediator.Send(new GetByChildIdQuery { Id = id });
            return Ok(result);
        }
    }
}
