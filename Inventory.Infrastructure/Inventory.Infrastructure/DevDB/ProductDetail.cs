using System;
using System.Collections.Generic;

namespace PersonalWork.Infrastructure.DevDB;

public partial class ProductDetail
{
    public int Id { get; set; }

    public int ProductUrlid { get; set; }

    public int ProductId { get; set; }

    public long? ReferenceNo { get; set; }

    public string Sku { get; set; } = null!;

    public string? Description { get; set; }

    public string? TypeOfPakcing { get; set; }

    public decimal? Price { get; set; }

    public string? InnerOuter { get; set; }

    public string? Cbmcutf { get; set; }

    public string? CartonSize { get; set; }

    public string? Gwnkg { get; set; }

    public string? PackSize { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? CatCode { get; set; }

    public string? Details { get; set; }

    public string? Battery { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsActive { get; set; }

    public decimal? Width { get; set; }

    public decimal? Depth { get; set; }

    public decimal? Height { get; set; }
}
