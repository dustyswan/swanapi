using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class CrmActivityMst
{
    public Guid ActivityId { get; set; }

    public Guid? DealId { get; set; }

    public Guid? UserId { get; set; }

    public DateTime? ActivityDate { get; set; }

    public DateTime? ActivityTime { get; set; }

    public string? ActivityType { get; set; }

    public string? Description { get; set; }

    public string? Status { get; set; }

    public string? Label { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
