using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWork.Application.Command.Users.LogoutUser
{
    public class LogoutUserCommand :IRequest
    {
        public int Id { get; set;}
        public string AccessToken { get; set;}
        public string UserName { get; set;}
    }
}
