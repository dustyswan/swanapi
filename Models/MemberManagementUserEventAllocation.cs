using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class MemberManagementUserEventAllocation
{
    public Guid MemberManagementUserEventAllocationId { get; set; }

    public Guid? MemberManagementId { get; set; }

    public Guid? EventId { get; set; }

    public Guid? UserId { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? AssociationMemberId { get; set; }

    public bool? IsAddFromAddSchedule { get; set; }

    public bool? IsUnregister { get; set; }
}
