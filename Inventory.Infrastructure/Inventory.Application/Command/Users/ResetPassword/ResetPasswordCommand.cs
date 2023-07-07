using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWork.Application.Command.Users.ResetPassword
{
    public class ResetPasswordCommand :IRequest
    {
        public string EmailId { get; set; }
    }
}
