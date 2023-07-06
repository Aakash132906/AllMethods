using System;
using System.Collections.Generic;

namespace PersonalWork.Infrastructure.LocalDB;

public partial class Category
{
    public int Id { get; set; }

    public string CatId { get; set; } = null!;

    public string? ParentCatId { get; set; }

    public string? CatName { get; set; }

    public string? CatUrl { get; set; }

    public string CatType { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? MapId { get; set; }

    public bool IsActive { get; set; }
}
