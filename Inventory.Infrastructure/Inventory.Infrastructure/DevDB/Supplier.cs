using System;
using System.Collections.Generic;

namespace PersonalWork.Infrastructure.DevDB;

public partial class Supplier
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Domain { get; set; } = null!;

    public string? DomainUrl { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsActive { get; set; }
}
