using AutoMapper;
using PersonalWork.Application.Command.Users.CreateUser;
using PersonalWork.Application.Queries.Products1;
using PersonalWork.Application.Queries.Products1.GetProduct1;
using PersonalWork.Application.Queries.Users;
using PersonalWork.Domain.DBModel;
using PersonalWork.Infrastructure.LocalDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWork.Application.Common.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateUserCommand, User>().ReverseMap();
            CreateMap<GetUserQuery, User>().ReverseMap();
           
            CreateMap<User, UserDto>().ReverseMap();



            CreateMap<GetProduct1AllQuery, Product1>().ReverseMap();
            CreateMap<Product1, Product1Dto>().ReverseMap();
        }
    }
}

