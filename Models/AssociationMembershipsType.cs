using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class AssociationMembershipsType
{
    public Guid AssociationMembershipsTypesId { get; set; }

    public Guid? AssociationId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public decimal? Cost { get; set; }

    public string? Frequency { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? MembershipType { get; set; }
}
