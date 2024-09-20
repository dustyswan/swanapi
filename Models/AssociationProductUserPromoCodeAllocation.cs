using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class AssociationProductUserPromoCodeAllocation
{
    public Guid AssociationProductUserPromoCodeAllocationId { get; set; }

    public Guid? AssociationProductPaymentId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? AssociationProductId { get; set; }

    public Guid? ProductPromoCodeId { get; set; }

    public decimal? DiscountAmount { get; set; }

    public decimal? TotalDiscountAmount { get; set; }

    public bool? IsUsed { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public Guid? AssociationProductUserAllocationId { get; set; }

    public bool? IsUnregister { get; set; }
}
