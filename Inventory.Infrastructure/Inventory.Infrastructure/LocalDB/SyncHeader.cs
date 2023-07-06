using System;
using System.Collections.Generic;

namespace PersonalWork.Infrastructure.LocalDB;

public partial class SyncHeader
{
    public int BatchId { get; set; }

    public int SupplierId { get; set; }

    public string SyncType { get; set; } = null!;

    public int TotalCount { get; set; }

    public int? CompletedCount { get; set; }

    public DateTime QueuedOn { get; set; }

    public DateTime? StaredOn { get; set; }

    public DateTime? CompletedOn { get; set; }

    public string Status { get; set; } = null!;
}
