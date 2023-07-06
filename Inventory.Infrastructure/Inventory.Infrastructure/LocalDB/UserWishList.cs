using System;
using System.Collections.Generic;

namespace PersonalWork.Infrastructure.LocalDB;

public partial class UserWishList
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string ItemType { get; set; } = null!;

    public string ReferenceId { get; set; } = null!;

    public bool? Notification { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
