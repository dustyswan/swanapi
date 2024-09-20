using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class ExhibitorSubscriptionPayment
{
    public Guid ExhibitorSubscriptionPaymentId { get; set; }

    public Guid? UserId { get; set; }

    public string? PaymentReference { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? Discount { get; set; }

    public string? PaymentStatus { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }

    public int? SubscriptionId { get; set; }

    public Guid? BoothBookingPaymentId { get; set; }

    public bool? IsUnregister { get; set; }
}
