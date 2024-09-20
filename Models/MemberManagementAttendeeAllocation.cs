using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class MemberManagementAttendeeAllocation
{
    public Guid MemberManagementAttendeeAllocationId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? AssociationMembersId { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? MemberManagementId { get; set; }

    public bool? IsRegistrationCancelEmailSend { get; set; }

    public bool? IsUnregister { get; set; }
}
