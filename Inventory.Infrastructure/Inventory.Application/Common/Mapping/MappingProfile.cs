using AutoMapper;
using PersonalWork.Application.Queries;
using PersonalWork.Application.Queries.Users;
using PersonalWork.Domain.DBModel;
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
            //CreateMap<UpdateUserCommand, User>().ReverseMap();
            CreateMap<GetUserQuery, User>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}

