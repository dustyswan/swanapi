using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class CompanyUserAllocationOld
{
    public Guid CompanyUserAllocationId { get; set; }

    public Guid? CompanyId { get; set; }

    public Guid? UserId { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool? IsProductAccess { get; set; }

    public bool? IsCompanyAccess { get; set; }

    public bool? IsTeamMemberAccess { get; set; }

    public bool? IsAdmin { get; set; }
}
