using System;
using System.Collections.Generic;

namespace PersonalWork.Infrastructure.LocalDB;

public partial class UserAction
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsActive { get; set; }
}
