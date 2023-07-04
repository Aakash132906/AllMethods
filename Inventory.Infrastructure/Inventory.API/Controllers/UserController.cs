using Inventory.API.Controllers;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalWork.Application.Queries.Users;
using PersonalWork.Application.Queries.Users.GetQueryTwoField;
using PersonalWork.Application.Queries.Users.GetUserId;

namespace PersonalWork.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController
    {
        [HttpGet("All")]
        public async Task<IActionResult> GetAll()
      => Ok(await Mediator.Send(new GetUserQuery { }));
        [HttpGet("UserId")]
        public async Task<IActionResult> Get(int Id)
    => Ok(await Mediator.Send(new GetUserIdQuery { Id = Id})); 
        [HttpGet("UserId&&UserToken")]
        public async Task<IActionResult> Get(int Id,string UserToken)
    => Ok(await Mediator.Send(new GetUserIdUserTokenQuery { Id = Id, UserToken = UserToken }));
    }
}
