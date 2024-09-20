using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class ExhibitorSubscriptionAllocation
{
    public Guid ExhibitorSubscriptionAllocationId { get; set; }

    public int? SubscriptionId { get; set; }

    public Guid? UserId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? UpdatedBy { get; set; }

    public int? RemindBeforeDays { get; set; }

    public Guid? ExhibitorSubscriptionPaymentId { get; set; }

    public Guid? CompanyId { get; set; }

    public decimal? SubscriptionPrice { get; set; }

    public bool? IsUnregister { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
