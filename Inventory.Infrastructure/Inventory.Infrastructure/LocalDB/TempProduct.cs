using System;
using System.Collections.Generic;

namespace PersonalWork.Infrastructure.LocalDB;

public partial class TempProduct
{
    public int MainUrlid { get; set; }

    public string ProductUrl { get; set; } = null!;

    public long ProductId { get; set; }

    public long? ReferenceNo { get; set; }

    public string? Title { get; set; }

    public string MainImgUrl { get; set; } = null!;

    public decimal Price { get; set; }

    public string CatId { get; set; } = null!;

    public int SupplierId { get; set; }

    public bool IsActive { get; set; }
}
