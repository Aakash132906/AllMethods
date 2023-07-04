using System;
using System.Collections.Generic;

namespace PersonalWork.Infrastructure.DevDB;

public partial class Vproduct
{
    public string Name { get; set; } = null!;

    public int ParentId { get; set; }

    public string Code { get; set; } = null!;

    public int Id { get; set; }

    public long ItemNumber { get; set; }

    public int CategoryId { get; set; }

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public decimal? Width { get; set; }

    public decimal? Depth { get; set; }

    public decimal? Height { get; set; }

    public DateTime? UpdateDate { get; set; }
}
