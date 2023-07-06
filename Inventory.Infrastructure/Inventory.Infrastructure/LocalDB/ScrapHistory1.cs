using System;
using System.Collections.Generic;

namespace PersonalWork.Infrastructure.LocalDB;

public partial class ScrapHistory1
{
    public int Id { get; set; }

    public DateTime? ScrapDate { get; set; }

    public int New { get; set; }

    public int Removed { get; set; }
}
