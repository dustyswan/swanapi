using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class PushToken
{
    public Guid PushToeknId { get; set; }

    public Guid? UserId { get; set; }

    public string? DeviceId { get; set; }

    public string? PushToken1 { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
