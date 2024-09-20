using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class ProductPrice
{
    public Guid ProductPriceId { get; set; }

    public Guid? ExhibitorProductId { get; set; }

    public decimal? Price { get; set; }

    public string? SubscriptionType { get; set; }

    public string? SubscriptionBase { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
