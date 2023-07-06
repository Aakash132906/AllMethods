using System;
using System.Collections.Generic;

namespace PersonalWork.Infrastructure.LocalDB;

public partial class MainUrl
{
    public int Id { get; set; }

    public int? SupplierId { get; set; }

    public string MainUrl1 { get; set; } = null!;

    public int? TotalPage { get; set; }

    public int? CompletedPage { get; set; }

    public int? CatId { get; set; }

    public string? LastRunUrl { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? Status { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }
}
