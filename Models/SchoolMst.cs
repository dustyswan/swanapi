using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class SchoolMst
{
    public Guid SchoolId { get; set; }

    public string SchoolName { get; set; } = null!;

    public Guid? SchoolDistrictId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }
}
