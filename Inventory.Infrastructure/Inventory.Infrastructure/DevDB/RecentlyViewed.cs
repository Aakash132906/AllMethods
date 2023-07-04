using System;
using System.Collections.Generic;

namespace PersonalWork.Infrastructure.DevDB;

public partial class RecentlyViewed
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public long ItemNumber { get; set; }

    public DateTime ViewedOn { get; set; }
}
