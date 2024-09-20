using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class BoothSalesUserAllocation
{
    public Guid EventBookingVenderAllocationId { get; set; }

    public Guid? ExhibitorBoothAllocationId { get; set; }

    public Guid? VenderId { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? SalesRepresentativeType { get; set; }

    public Guid? BoothId { get; set; }

    public bool? IsUnregister { get; set; }

    public Guid? UserId { get; set; }
}
