using System;
using System.Collections.Generic;

namespace PersonalWork.Infrastructure.LocalDB;

public partial class UserRoleMapping
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int UserRoleId { get; set; }

    public DateTime CreatedOn { get; set; }
}
