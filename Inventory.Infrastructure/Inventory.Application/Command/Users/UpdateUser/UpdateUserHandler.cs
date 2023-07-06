using AutoMapper;
using MediatR;
using PersonalWork.Application.Abstractions.Repositories;
using PersonalWork.Domain.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWork.Application.Command.Users.UpdateUser
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, User>
    {
        public IUnitOfWork UnitOfWork;
        public IMapper mapper;
        public UpdateUserHandler(IUnitOfWork UnitOfWork, IMapper mapper)
        {
            this.UnitOfWork= UnitOfWork;
            this.mapper= mapper;    
        }
        public async Task<User> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var updateUser = await UnitOfWork.GetReposiotory<User>().GetByAsync(x => x.Id == request.Id && x.UserToken == request.UserToken); 
            if(updateUser == null) {
                throw new Exception("Invalid Autherition");
            }
            updateUser.Id= request.Id;
            updateUser.FirstName= request.FirstName;
            updateUser.LastName= request.LastName;
            updateUser.UserName= request.UserName;
            updateUser.EmailId= request.EmailId;
            updateUser.Passwd= request.Passwd; 
            updateUser.RoleId= request.RoleId;
            updateUser.PhoneNo= request.PhoneNo;
            updateUser.IsActive= request.IsActive==true?true:false;
            await UnitOfWork.CompleteAsync();
            return updateUser;


        }
    }
}
