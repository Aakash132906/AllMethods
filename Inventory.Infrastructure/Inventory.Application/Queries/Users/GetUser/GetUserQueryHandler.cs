using AutoMapper;
using PersonalWork.Application.Abstractions.Repositories;
using MediatR;
using PersonalWork.Domain.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWork.Application.Queries.Users.GetUser
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, List<UserDto>>
    {
        public IUnitOfWork UnitOfWork;

        public IMapper Mapper;

        public GetUserQueryHandler(IUnitOfWork UnitOfWork, IMapper Mapper)
        {
            this.UnitOfWork = UnitOfWork;
            this.Mapper = Mapper;
        }
        public async Task<List<UserDto>> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var response = await UnitOfWork.GetReposiotory<User>().GetListAsync();
            var data = Mapper.Map<List<UserDto>>(response);
            return data;
        }
    }
}
