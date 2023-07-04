using System;
using System.Collections.Generic;

namespace PersonalWork.Infrastructure.DevDB;

public partial class UserSetting
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public bool? EmailNotification { get; set; }

    public bool? Smsnotification { get; set; }

    public string? Favourties { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
