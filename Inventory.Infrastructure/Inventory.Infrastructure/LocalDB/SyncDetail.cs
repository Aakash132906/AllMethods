using System;
using System.Collections.Generic;

namespace PersonalWork.Infrastructure.LocalDB;

public partial class SyncDetail
{
    public int Id { get; set; }

    public int BatchId { get; set; }

    public string ProductData { get; set; } = null!;

    public DateTime QueuedOn { get; set; }

    public DateTime? StaredOn { get; set; }

    public DateTime? CompletedOn { get; set; }

    public string Status { get; set; } = null!;
}
