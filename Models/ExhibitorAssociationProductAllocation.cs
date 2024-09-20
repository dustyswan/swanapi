using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class ExhibitorAssociationProductAllocation
{
    public Guid ExhibitorAssociationProductAllocationId { get; set; }

    public Guid? AssociationProductPaymentId { get; set; }

    public Guid? AssocitionProductId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? BoothId { get; set; }

    public Guid? CompanyId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public int? Quantity { get; set; }

    public decimal? Discount { get; set; }

    public decimal? Price { get; set; }

    public decimal? TotalAmount { get; set; }

    public bool? IsUnregister { get; set; }
}
