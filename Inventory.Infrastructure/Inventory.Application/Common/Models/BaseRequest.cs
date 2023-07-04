using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWork.Application.Common.Models
{
    public class BaseRequest
    {
        public int Page { get; set; }
        public int PerPage { get; set; }
        public List<Where> Filter { get; set; }


    }
}
