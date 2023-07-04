using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalWork.Domain.DBModel
{
    public partial class Product
    {
        public int Id { get; set; }

        public int MainUrlid { get; set; }

        public string ProductUrl { get; set; } = null!;

        public long ProductId { get; set; }

        public long? ReferenceNo { get; set; }

        public string? Title { get; set; }

        public string MainImgUrl { get; set; } = null!;

        public decimal Price { get; set; }

        public string CatId { get; set; } = null!;

        public bool HaveProduct { get; set; }

        public string ImgDownloaded { get; set; } = null!;

        public string IsEdited { get; set; } = null!;

        public int SupplierId { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsActive { get; set; }

        public long? ItemNumber { get; set; }
    }
