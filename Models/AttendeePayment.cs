using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class AttendeePayment
{
    public Guid AttendeePaymentId { get; set; }

    public Guid? ConferenceId { get; set; }

    public Guid? UserId { get; set; }

    public string? PaymentReference { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? Tax { get; set; }

    public decimal? Discount { get; set; }

    public string? PaymentStatus { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }

    public bool? IsFigCreated { get; set; }

    public string? PaymentMode { get; set; }

    public string? ChequeNumber { get; set; }

    public DateTime? ChequeDate { get; set; }

    public string? ChequeStatus { get; set; }

    public string? UserType { get; set; }

    public Guid? ConferenceAttendeePriceTypeId { get; set; }

    public bool? IsUnregister { get; set; }
}
