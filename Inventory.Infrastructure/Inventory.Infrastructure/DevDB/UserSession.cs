using System;
using System.Collections.Generic;

namespace PersonalWork.Infrastructure.DevDB;

public partial class UserSession
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string AccessToken { get; set; } = null!;

    public DateTime LoggedOn { get; set; }

    public DateTime? ExpiredAt { get; set; }
}
