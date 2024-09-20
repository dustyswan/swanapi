using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class PromoCodeUserAllocation
{
    public Guid PromoCodeUserAllocationId { get; set; }

    public Guid? ConferenceId { get; set; }

    public Guid? UserId { get; set; }

    public bool? IsUsed { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreateddBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? PromoCodeId { get; set; }

    public decimal? DiscountAmount { get; set; }

    public Guid? PaymentId { get; set; }

    public bool? IsUnregister { get; set; }
}
