using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWork.Application.Queries.Products1.GetProduct1
{
    public class GetProduct1AllQuery :IRequest<List<Product1Dto>>
    {
        public int? UserId { get; set; }
        public string? AccessToken { get; set; }
        public int Id { get; set; }

        //public long ItemNumber { get; set; }

        //public int CategoryId { get; set; }

        //public string? Description { get; set; }

        //public string? TypeOfPakcing { get; set; }

        //public decimal Price { get; set; }

        //public string? InnerOuter { get; set; }

        //public string? Cbmcutf { get; set; }

        //public string? CartonSize { get; set; }

        //public string? Gwnkg { get; set; }

        //public string? PackSize { get; set; }

        //public decimal? Width { get; set; }

        //public decimal? Depth { get; set; }

        //public decimal? Height { get; set; }

        //public DateTime? UpdateDate { get; set; }

        //public string? Battery { get; set; }

        //public long SourceId { get; set; }

        //public long? ReferenceNo { get; set; }

        //public DateTime CreatedOn { get; set; }

        //public DateTime? ModifiedOn { get; set; }

        //public bool IsActive { get; set; }


    }
}
 