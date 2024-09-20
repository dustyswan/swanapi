using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class VwAttendeeReport
{
    public Guid UserId { get; set; }

    public string? CustomerName { get; set; }

    public string CustomerEmail { get; set; } = null!;

    public string? CompanyName { get; set; }

    public string? Phone { get; set; }

    public string? PurchaseType { get; set; }

    public decimal? TotalCost { get; set; }

    public string? Ponumber { get; set; }

    public string ChargeType { get; set; } = null!;

    public string? CheckNumber { get; set; }

    public string? PaymentStatus { get; set; }

    public DateTime? DateRegistered { get; set; }

    public string AdaDietaryRestrictions { get; set; } = null!;

    public string? RegisteredBy { get; set; }
}
