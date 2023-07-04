using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWork.Application.Common.Models
{
    public class Where
    {
        public string Field { get; set; }
        public FilterType FilterType { get; set; }
        public string Value { get; set; }


    }
}
