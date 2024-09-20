﻿using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class UserRoleAllocation
{
    public Guid UserRoleAllocationId { get; set; }

    public int? RoleId { get; set; }

    public Guid? UserId { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
