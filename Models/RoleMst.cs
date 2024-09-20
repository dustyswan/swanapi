using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class RoleMst
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public bool? IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid? Createdby { get; set; }

    public Guid? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }
}
