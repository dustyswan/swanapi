using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class SubscriptionConferenceAllocation
{
    public int SubscriptionConferenceAllocationId { get; set; }

    public int? SubscriptionId { get; set; }

    public Guid? ConferenceId { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? SubscriptionTitle { get; set; }
}
