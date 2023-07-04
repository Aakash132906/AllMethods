using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWork.Application.Queries.Users.GetQueryTwoField
{
    public class GetUserIdUserTokenQuery :IRequest<UserDto>
    {
        public int Id { get; set; }
        public string UserToken { get; set; } = null!;
    }
}
