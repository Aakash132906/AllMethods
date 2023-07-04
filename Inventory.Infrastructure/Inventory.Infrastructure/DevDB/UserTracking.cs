using System;
using System.Collections.Generic;

namespace PersonalWork.Infrastructure.DevDB;

public partial class UserTracking
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int ActionId { get; set; }

    public string PageUrl { get; set; } = null!;

    public DateTime Checkin { get; set; }

    public DateTime? CheckOut { get; set; }

    public string? SearchParams { get; set; }

    public TimeSpan? Difference { get; set; }

    public decimal? ActionRate { get; set; }
}
