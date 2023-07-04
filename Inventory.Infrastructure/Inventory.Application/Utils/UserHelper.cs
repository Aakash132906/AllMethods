using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWork.Application.Utils
{
    public class UserHelper
    {
        private readonly HttpContext _context;
        public UserHelper(IHttpContextAccessor contextAccessor)
        {
            _context = contextAccessor.HttpContext;
        }
        public int GetUserId()
        {
            if (int.TryParse(_context.User.Identity.Name, out int id))
                return id;



            throw new UnauthorizedAccessException("User is not authenticated");
        }
    }
}
