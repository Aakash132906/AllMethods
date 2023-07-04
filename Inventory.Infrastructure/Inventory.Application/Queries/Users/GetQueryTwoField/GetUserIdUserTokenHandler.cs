using AutoMapper;
using MediatR;
using PersonalWork.Application.Abstractions.Repositories;
using PersonalWork.Domain.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWork.Application.Queries.Users.GetQueryTwoField
{
    public class GetUserIdUserTokenHandler : IRequestHandler<GetUserIdUserTokenQuery, UserDto>
    {
        public IUnitOfWork UnitOfWork;
        public IMapper Mapper;
        public GetUserIdUserTokenHandler(IUnitOfWork UnitOfWork, IMapper Mapper)
        {
            this.UnitOfWork = UnitOfWork;
            this.Mapper = Mapper;
        }
        public async Task<UserDto> Handle(GetUserIdUserTokenQuery request, CancellationToken cancellationToken)
        {
            var userid = await UnitOfWork.GetReposiotory<User>().GetByAsync(x=> x.Id==request.Id && x.UserToken==request.UserToken) ;
            if (userid == null)
            {
                return null;
            }
            var data= Mapper.Map<UserDto>(userid);
            return data;
        }
    }
}
