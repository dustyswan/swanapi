using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class MemberManagementPayment
{
    public Guid MemberManagementPaymentId { get; set; }

    public Guid? MemberManagementId { get; set; }

    public Guid? ConferenceId { get; set; }

    public string? PaymentReference { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? PaymentStatus { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public decimal? Discount { get; set; }

    public Guid? ConferenceAttendeePriceTypeId { get; set; }

    public string? PaymentMode { get; set; }

    public bool? IsFigCreated { get; set; }

    public bool? IsUnregister { get; set; }
}
