using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class RoleMenuAllocation
{
    public Guid RoleMenuAllocationId { get; set; }

    public int? RoleId { get; set; }

    public int? MenuId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }
}
