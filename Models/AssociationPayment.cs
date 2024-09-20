using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class AssociationPayment
{
    public Guid AssociationPaymentId { get; set; }

    public Guid? AssociationId { get; set; }

    public string? PaymentReference { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? Discount { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaymentStatus { get; set; }

    public Guid? AssociationMembershipsTypesId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public Guid? AssociationMemberId { get; set; }

    public string? CompanyName { get; set; }

    public string? RegisterType { get; set; }

    public string? ResendEmailList { get; set; }
}
