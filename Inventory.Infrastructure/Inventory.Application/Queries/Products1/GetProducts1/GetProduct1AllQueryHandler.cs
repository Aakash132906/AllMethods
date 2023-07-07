using AutoMapper;
using MediatR;
using PersonalWork.Application.Abstractions.Repositories;
using PersonalWork.Application.Queries.Users;
using PersonalWork.Domain.DBModel;
using PersonalWork.Infrastructure.LocalDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWork.Application.Queries.Products1.GetProduct1
{
    public class GetProduct1AllQueryHandler : IRequestHandler<GetProduct1AllQuery, List<Product1Dto>>
    {
        public IUnitOfWork unitOfWork;
        public IMapper mapper;
        public GetProduct1AllQueryHandler(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task <List<Product1Dto>> Handle(GetProduct1AllQuery request, CancellationToken cancellationToken)
        {
            //var getProduct = await unitOfWork.GetReposiotory<Product1>().GetByAsync(x => x.CategoryId == 5);
            //if(getProduct == null) { throw new Exception("Error"); }
            //var data = mapper.Map<List<Product1Dto>>(getProduct);
            //return data;
            var validUser = await unitOfWork.GetReposiotory<User>().GetByAsync(x => x.Id == request.UserId && x.AccessToken == request.AccessToken);
            if (validUser != null)
            {
            
                    var getProduct =  unitOfWork.GetReposiotory<Product1>().GetListAsync().Result.Take(50).ToList();
                    var data = mapper.Map<List<Product1Dto>>(getProduct);
                    return data;
                
               
            }

            throw new Exception("Invalid Autheration");

        }
    }
}
