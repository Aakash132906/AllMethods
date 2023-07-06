using System;
using System.Collections.Generic;

namespace PersonalWork.Infrastructure.LocalDB;

public partial class Rfqheader
{
    public int BatchId { get; set; }

    public int UserId { get; set; }

    public int TotalProducts { get; set; }

    public int? Reviewed { get; set; }

    public int? Completed { get; set; }

    public int? Pending { get; set; }

    public int? Rejected { get; set; }

    public string? Status { get; set; }

    public DateTime RequestedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
