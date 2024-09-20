using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class Payment
{
    public Guid PaymentId { get; set; }

    public Guid? EventBookingId { get; set; }

    public string? PaymentPlatfom { get; set; }

    public decimal? PaymentAmount { get; set; }

    public string? PaymentReference { get; set; }

    public string? PaymentStatus { get; set; }

    public string? PaymentFees { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? ConferenceId { get; set; }

    public string? UserType { get; set; }
}
