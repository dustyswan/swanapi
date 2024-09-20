using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class MemberManagementInvoice
{
    public Guid MemberManagementInvoiceId { get; set; }

    public Guid? MemberManagementId { get; set; }

    public string? AddressLine1 { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PurchaseOrderNumber { get; set; }

    public string? ZipCode { get; set; }

    public string? InvoiceInstructions { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public string? InvoiceStatus { get; set; }

    public Guid? CompleteByUserId { get; set; }

    public DateTime? CompleteDate { get; set; }

    public DateTime? ReceivedPaymentDate { get; set; }

    public string? CheckNumber { get; set; }

    public bool? IsUnregister { get; set; }
}
