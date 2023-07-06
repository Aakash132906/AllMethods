using System;
using System.Collections.Generic;

namespace PersonalWork.Infrastructure.LocalDB;

public partial class UserAccessObject
{
    public int AccessId { get; set; }

    public string AccessName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string Relation { get; set; } = null!;

    public int DisplayOrder { get; set; }

    public int ParentId { get; set; }

    public string AccessLevel { get; set; } = null!;
}
