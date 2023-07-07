using AutoMapper;
using MediatR;
using PersonalWork.Application.Abstractions.Repositories;
using PersonalWork.Application.Common.Exceptions;
using PersonalWork.Domain.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWork.Application.Command.Users.LogoutUser
{
    public class LogoutUserHandler : IRequestHandler<LogoutUserCommand>
    {
        public IMapper Mapper;
        public IUnitOfWork UnitOfWork;
        public LogoutUserHandler(IMapper Mapper, IUnitOfWork UnitOfWork)
        {
            this.Mapper = Mapper;
            this.UnitOfWork = UnitOfWork;

        }
        public async Task<Unit> Handle(LogoutUserCommand request, CancellationToken cancellationToken)
        {
            if (request.Id == null || request.Id<=0)
            {
                throw new Exception("Invalid UserId");
            }
            if(request.UserName == null)
            {
                throw new  BadRequestException(ErrorCodes.UserNotExists);
            }
            if(request.AccessToken == null)
            {
                throw new Exception("Invalid AccessToken");
            }
            try
            {
                var logoutUser = await UnitOfWork.GetReposiotory<User>().GetByAsync(x => x.Id == request.Id && x.AccessToken == request.AccessToken && x.UserName == request.UserName);
                if (logoutUser != null)
                {
                    logoutUser.AccessToken = " ";
                    logoutUser.IsActive = false;
                    await UnitOfWork.CompleteAsync();
                    

                }
            }
            catch (Exception)
            {

                throw new Exception("Logout successfully");
            }
            throw new Exception("Logout Failed");
        }
    }
}
