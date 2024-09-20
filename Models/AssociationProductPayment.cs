using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class AssociationProductPayment
{
    public Guid AssociationProductPaymentId { get; set; }

    public Guid? AssociationId { get; set; }

    public Guid? UserId { get; set; }

    public string? PaymentReference { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? Discount { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentStatus { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public string? OrderNumber { get; set; }

    public string? ShippingAddress { get; set; }

    public Guid? AssociationMemberId { get; set; }

    public string? CompanyName { get; set; }

    public Guid? BoothBookingPaymentId { get; set; }

    public bool? IsUnregister { get; set; }

    public Guid? AssociationMemberAdminId { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? ShippingAddressType { get; set; }

    public string? ResendEmailList { get; set; }
}
