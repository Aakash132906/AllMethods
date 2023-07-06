using AutoMapper;
using MediatR;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using PersonalWork.Application.Abstractions.Repositories;
using PersonalWork.Application.Utils;
using PersonalWork.Domain.DBModel;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWork.Application.Command.Users.LoginUser
{
    public class LoginUserHandler : IRequestHandler<LoginUserCommand, Token>
    {

        public IUnitOfWork UnitOfWork;
        public IMapper mapper;
        private readonly TokenService _tokenService;
        public LoginUserHandler(IUnitOfWork UnitOfWork, IMapper mapper, TokenService tokenService) {
        this.UnitOfWork = UnitOfWork;
            this.mapper = mapper;
            _tokenService = tokenService;
        }
        public async Task<Token> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            if(request.userName == null)
            {
                throw new Exception("Invalid UserName");
            }
            if ( request.Passwd == null)
            {
                throw new Exception("Invalid Password");
            }
           var username = await UnitOfWork.GetReposiotory<User>().GetByAsync(x => x.UserName == request.userName && x.Passwd == request.Passwd);
            //username = await UnitOfWork.GetReposiotory<User>().GetByAsync(x=>x.UserName == request.UserName);
            // Password= await UnitOfWork.GetReposiotory<User>().GetByAsync(x=>x.Passwd == request.Passwd);
            if(username !=null)
            {
                 var  token = _tokenService.CreateToken(username.Id, new string[] { "" });
               
                if (token != null)
                {
                    var userdata = await UnitOfWork.GetReposiotory<User>().GetByAsync(x => x.Id == username.Id && x.Passwd == username.Passwd);
                    if (userdata != null)
                    {
                        userdata.AccessToken = token.AccessToken;
                        userdata.IsActive = true;
                        await UnitOfWork.CompleteAsync();
                        var data =mapper.Map<Token>(token);
                        return data;
                    }
                    
                }
          
            }
            else
            {
                throw new Exception("Invalid User Name and password");
            }
         
            throw new Exception("");

        }
       
    }

    //public string GenerateOTP()
    //{
    //    Random random = new Random();
    //    int otpNumber = random.Next(100000, 999999);
    //    return otpNumber.ToString();
    //}
}
