using System;
using System.Collections.Generic;

namespace PersonalWork.Infrastructure.LocalDB;

public partial class ApiAuditLog
{
    public int? ApiuserId { get; set; }

    public Guid? CorrelationId { get; set; }

    public string? Refferer { get; set; }

    public string? Uri { get; set; }

    public string? ContentType { get; set; }

    public string? HttpMethod { get; set; }

    public string? StatusCode { get; set; }

    public string? Header { get; set; }

    public string? BodyContent { get; set; }

    public string? BodyContentSizeInBytes { get; set; }

    public bool? IsRequest { get; set; }

    public string? Ipaddress { get; set; }

    public DateTime? OriginatedOn { get; set; }

    public DateTime? ReachedOn { get; set; }
}
