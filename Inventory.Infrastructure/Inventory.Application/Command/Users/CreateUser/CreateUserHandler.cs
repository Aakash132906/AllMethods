using AutoMapper;
using MediatR;
using PersonalWork.Application.Abstractions.Repositories;
using PersonalWork.Domain.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWork.Application.Command.Users.CreateUser
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, User>
    {
        public IUnitOfWork UnitOfWork;
        public IMapper mapper;
        public CreateUserHandler(IUnitOfWork UnitOfWork, IMapper mapper) {
            this.UnitOfWork = UnitOfWork;
            this.mapper = mapper;
        }
        public async Task<User> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
           var createUser=mapper.Map<User>(request);
           await UnitOfWork.GetReposiotory<User>().AddAsync(createUser);
            await UnitOfWork.CompleteAsync();
            return createUser;
        }
    }
}
