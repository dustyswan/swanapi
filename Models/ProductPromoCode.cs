using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class ProductPromoCode
{
    public Guid ProductPromoCodeId { get; set; }

    public string? ProductPromoCode1 { get; set; }

    public string? PromoTitle { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? PromoType { get; set; }

    public decimal? PromoValue { get; set; }

    public decimal? MinValue { get; set; }

    public string? TeamsCondition { get; set; }

    public bool? Status { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? CreateddBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
