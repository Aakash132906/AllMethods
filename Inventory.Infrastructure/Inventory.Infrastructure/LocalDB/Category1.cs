using System;
using System.Collections.Generic;

namespace PersonalWork.Infrastructure.LocalDB;

public partial class Category1
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string Relation { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public int ParentId { get; set; }

    public string Code { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsActive { get; set; }

    public string? ImgUrl { get; set; }

    public string? Breadcrumb { get; set; }

    public int SequenceNo { get; set; }
}
