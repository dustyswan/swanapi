using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class ExhibitorBoothCompanyAllocation
{
    public Guid ExhibitorBoothCompanyAllocationId { get; set; }

    public Guid ExhibitorBoothAllocationId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? BoothId { get; set; }

    public Guid? CompanyId { get; set; }

    public bool? IsFloorPlanDisplayCompany { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }

    public bool? IsUnregister { get; set; }
}
