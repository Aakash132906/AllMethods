using System;
using System.Collections.Generic;

namespace PersonalWork.Infrastructure.DevDB;

public partial class ApiAuditErrorLog
{
    public int? CustomerId { get; set; }

    public Guid? CorrelationId { get; set; }

    public string? Message { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? Source { get; set; }

    public string? Referrer { get; set; }
}
