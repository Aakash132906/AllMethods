using Microsoft.AspNetCore.Mvc;
using PersonalWork.API.Controllers;
using PersonalWork.Application.Command.Users.LogoutUser;
using PersonalWork.Application.Queries.Products1.GetProduct1;
using PersonalWork.Application.Queries.Users;

namespace PersonalWork.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Product1Controller :BaseController
    {
        [HttpPost("GetAllProduct")]
        public async Task<IActionResult> GetAll(int UserId, string AccessToken)
         => Ok(await Mediator.Send(new GetProduct1AllQuery { UserId = UserId, AccessToken = AccessToken }));
    }
}
