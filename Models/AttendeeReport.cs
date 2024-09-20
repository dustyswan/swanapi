using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class AttendeeReport
{
    public string? CustomerName { get; set; }

    public string CustomerEmail { get; set; } = null!;

    public string? CompanyName { get; set; }

    public string? Phone { get; set; }

    public string? PurchaseType { get; set; }

    public decimal? TotalCost { get; set; }

    public string? Ponumber { get; set; }

    public string PaymentMethod { get; set; } = null!;

    public DateTime? DatePaid { get; set; }

    public string? CheckNumber { get; set; }

    public string PaymentStatus { get; set; } = null!;

    public string RefundStatus { get; set; } = null!;

    public DateTime? DateRegistered { get; set; }

    public string AdaDietaryRestrictions { get; set; } = null!;

    public string? RegisteredBy { get; set; }

    public string? SessionTitle { get; set; }

    public DateTime? SessionStartDate { get; set; }

    public string? SessionEndDate { get; set; }

    public string? SessionLocation { get; set; }
}
