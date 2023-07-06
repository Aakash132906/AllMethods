using System;
using System.Collections.Generic;

namespace PersonalWork.Infrastructure.LocalDB;

public partial class Rfqdetail
{
    public int Id { get; set; }

    public int BatchId { get; set; }

    public long ItemNumber { get; set; }

    public int Rqty { get; set; }

    public string? Ucomments { get; set; }

    public int Dqty { get; set; }

    public string? Scomments { get; set; }

    public DateTime RequestedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? Status { get; set; }
}
