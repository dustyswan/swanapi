using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class Subscription
{
    public int SubscriptionId { get; set; }

    public decimal? Price { get; set; }

    public string? PriceType { get; set; }

    public string? Duration { get; set; }

    public int? Value { get; set; }

    public string? Benefits { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? SubscriptionTitle { get; set; }

    public bool? DisplayAsProductInConference { get; set; }

    public bool? IsDiscountedSubscription { get; set; }

    public string? DiscountedType { get; set; }

    public decimal? DiscountedValue { get; set; }

    public decimal? TotalSubscriptionPrice { get; set; }
}
