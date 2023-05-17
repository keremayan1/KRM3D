using Application.Features.Adult.DTOs;
using Application.Features.Adult.Models;
using Application.Features.Adult.Queries.GetListAdult;
using Core.Application.Requests;
using Core.Shared.BaseController;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AdultsController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] PageRequest pageRequest)
        {
            AdultModel result = await Mediator.Send(new GetListAdultQuery { PageRequest = pageRequest });
            return Ok(result);
        }
    }
}
