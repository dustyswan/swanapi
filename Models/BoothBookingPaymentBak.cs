using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class BoothBookingPaymentBak
{
    public Guid BoothBookingPaymentId { get; set; }

    public Guid? ConferenceId { get; set; }

    public Guid? UserId { get; set; }

    public DateOnly? PaymentPlatfom { get; set; }

    public decimal? PaymentAmount { get; set; }

    public DateOnly? PaymentReference { get; set; }

    public DateOnly? PaymentStatus { get; set; }

    public DateOnly? PaymentFees { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public DateOnly? PaymentMode { get; set; }

    public DateOnly? ChequeNumber { get; set; }

    public DateTime? ChequeDate { get; set; }

    public DateOnly? ChequeStatus { get; set; }

    public decimal? Discount { get; set; }

    public DateOnly? UserType { get; set; }

    public bool? IsAllBoothRejected { get; set; }

    public decimal? BoothAmount { get; set; }

    public decimal? ProductAmount { get; set; }

    public decimal? EventAmount { get; set; }

    public bool? IsUnregister { get; set; }
}
