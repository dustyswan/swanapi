using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class PromoCode
{
    public Guid PromoCodeId { get; set; }

    public string? PromoCode1 { get; set; }

    public string? PromoTitle { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? PromoType { get; set; }

    public decimal? PromoValue { get; set; }

    public decimal? MinValue { get; set; }

    public string? TeamsCondition { get; set; }

    public bool? Status { get; set; }

    public Guid? CreateddBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? ConferenceId { get; set; }

    public string? Type { get; set; }
}
