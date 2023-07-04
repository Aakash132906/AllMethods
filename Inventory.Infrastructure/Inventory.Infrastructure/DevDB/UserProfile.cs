using System;
using System.Collections.Generic;

namespace PersonalWork.Infrastructure.DevDB;

public partial class UserProfile
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string? BusinessName { get; set; }

    public string? BusinessLocation { get; set; }

    public string? ModeOfPayment { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Pincode { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
