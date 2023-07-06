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
    public class GetUserIdUserTokenQueryHandler : IRequestHandler<GetUserIdUserTokenQuery, UserDto>
    {
        User userid = new User();

        public IUnitOfWork UnitOfWork;
        public IMapper Mapper;
        public GetUserIdUserTokenQueryHandler(IUnitOfWork UnitOfWork, IMapper Mapper)
        {
            this.UnitOfWork = UnitOfWork;
            this.Mapper = Mapper;
        }
        public async Task<UserDto> Handle(GetUserIdUserTokenQuery request, CancellationToken cancellationToken)
        {
            if ((request.Id.ToString() == null) || (request.Id <= 0))
            {
                throw new Exception("Invalid User Id");
            }
            if (request.UserToken == null)
            {
                throw new Exception("Invalid User Token");
            }


            userid = await UnitOfWork.GetReposiotory<User>().GetByAsync(x => x.Id == request.Id && x.UserToken == request.UserToken);
            if (userid == null)
            {

                throw new Exception("Data Not Found");
            }


            var data = Mapper.Map<UserDto>(userid);

            return data;
        }
    }
}
