using AutoMapper;
using MediatR;
using PersonalWork.Application.Abstractions.Repositories;
using PersonalWork.Domain.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWork.Application.Queries.Users.GetUserId
{
    internal class GetUserIdHandler : IRequestHandler<GetUserIdQuery, UserDto>
    {
        public IUnitOfWork UnitOfWork;
        public IMapper mapper;
        public GetUserIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.UnitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<UserDto> Handle(GetUserIdQuery request, CancellationToken cancellationToken)
        {
            var responce = await UnitOfWork.GetReposiotory<User>().GetAsync(request.Id);
            if (responce == null)
            {
                return null;
            }
            else
            {

                var data = mapper.Map<UserDto>(responce);

                return data;
            }
        }
        
    }
}
