using System;
using System.Collections.Generic;

namespace PersonalWork.Infrastructure.DevDB;

public partial class ScrapHistory
{
    public int Id { get; set; }

    public DateTime? ScrapDate { get; set; }

    public int New { get; set; }

    public int Removed { get; set; }
}
