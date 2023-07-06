using MediatR;
using PersonalWork.Application.Utils;
using PersonalWork.Domain.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWork.Application.Command.Users.LoginUser
{
    public class LoginUserCommand : IRequest<Token>
    {
        public string userName { get; set; } = null!;

        public string Passwd { get; set; } = null!;

    }
   
}
