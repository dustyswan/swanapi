using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class MemberManagementEventAllocation
{
    public Guid MemberManagementEventAllocationId { get; set; }

    public Guid? MemberManagementId { get; set; }

    public Guid? EventOrSessionId { get; set; }

    public int? EventAttendee { get; set; }

    public decimal? EventPrice { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? Type { get; set; }

    public bool? IsAddFromAddSchedule { get; set; }

    public bool? IsUnregister { get; set; }
}
