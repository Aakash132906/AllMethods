using System;
using System.Collections.Generic;

namespace PersonalWork.Infrastructure.LocalDB;

public partial class Classification
{
    public int Id { get; set; }

    public int TypeId { get; set; }

    public int Count { get; set; }

    public string? TypeName { get; set; }

    public int ItemModelId { get; set; }

    public int ItemCount { get; set; }

    public string? ItemModelName { get; set; }
}
