using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class AssociationMembersTypeAllocation
{
    public Guid AssociationMembersTypeAllocationId { get; set; }

    public Guid? AssociationMembersId { get; set; }

    public Guid? UserId { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
