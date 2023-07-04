using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWork.Application.Utils
{
    public class CustomerCredientials
    {
        private readonly HttpContext context;

        public CustomerCredientials(HttpContext _Context)
        {
            context = _Context;
        }
    }
}
