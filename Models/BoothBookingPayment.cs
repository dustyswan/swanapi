using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class BoothBookingPayment
{
    public Guid BoothBookingPaymentId { get; set; }

    public Guid? ConferenceId { get; set; }

    public Guid? UserId { get; set; }

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

    public string? PaymentMode { get; set; }

    public string? ChequeNumber { get; set; }

    public DateTime? ChequeDate { get; set; }

    public string? ChequeStatus { get; set; }

    public decimal? Discount { get; set; }

    public string? UserType { get; set; }

    public bool? IsAllBoothRejected { get; set; }

    public decimal? BoothAmount { get; set; }

    public decimal? ProductAmount { get; set; }

    public decimal? EventAmount { get; set; }

    public bool? IsUnregister { get; set; }
}
