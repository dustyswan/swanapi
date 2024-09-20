using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class AssociationPaymentUserAllocation
{
    public Guid AssociationPaymentUserAllocationId { get; set; }

    public Guid? AssociationPaymentId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? AssociationMembershipsTypesId { get; set; }

    public decimal? Discount { get; set; }

    public decimal? TotalAmount { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public decimal? Price { get; set; }
}
