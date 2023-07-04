using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWork.Application.Queries.Users.GetUserId
{
    public class GetUserIdQuery: IRequest<UserDto>
    {
        public int Id { get; set; }
    
    }
}
