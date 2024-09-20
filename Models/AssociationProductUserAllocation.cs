using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class AssociationProductUserAllocation
{
    public Guid AssociationProductUserAllocationId { get; set; }

    public Guid? AssociationProductPaymentId { get; set; }

    public Guid? UserId { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? Discount { get; set; }

    public string? PaymentStatus { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public int? Quantity { get; set; }

    public Guid? AssociationProductId { get; set; }

    public decimal? Price { get; set; }

    public Guid? AssociationId { get; set; }

    public bool? IsUnregister { get; set; }
}
