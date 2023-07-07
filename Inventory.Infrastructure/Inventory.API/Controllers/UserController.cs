using Microsoft.AspNetCore.Mvc;
using PersonalWork.API.Controllers;
using PersonalWork.Application.Command.Users.CreateUser;
using PersonalWork.Application.Command.Users.LoginUser;
using PersonalWork.Application.Command.Users.LogoutUser;
using PersonalWork.Application.Command.Users.ResetPassword;
using PersonalWork.Application.Command.Users.UpdateUser;
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
    => Ok(await Mediator.Send(new GetUserIdQuery { Id = Id }));
        [HttpGet("UserId&&UserToken")]
        public async Task<IActionResult> Get(int Id, string UserToken)
    => Ok(await Mediator.Send(new GetUserIdUserTokenQuery { Id = Id, UserToken = UserToken }));

        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateUserCommand request)
=> Ok(await Mediator.Send(request));

        [HttpPost("Login")]
        public async Task<IActionResult> Login(string userName, string Passwd)
            => Ok(await Mediator.Send(new LoginUserCommand { userName = userName, Passwd = Passwd }));
        [HttpPost("Logout")]
        public async Task<IActionResult> Logout(int Id, string AccessToken,string UserName)
         => Ok(await Mediator.Send(new LogoutUserCommand { Id = Id, AccessToken = AccessToken, UserName= UserName }));
        [HttpPut("UserId")]
        public async Task<IActionResult> Update(UpdateUserCommand request)
            => Ok(await Mediator.Send(request));
        [HttpPost("ResetPassword")]
        public async Task<IActionResult> Update(ResetPasswordCommand request)
           => Ok(await Mediator.Send(request));
    }
}
