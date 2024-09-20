using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class NewAttendeeEventSessionAllocation
{
    public Guid SessionAllocationId { get; set; }

    public Guid? ConferenceId { get; set; }

    public Guid AttendeePaymentId { get; set; }

    public string? Type { get; set; }

    public Guid? SessionId { get; set; }

    public Guid? UserId { get; set; }

    public decimal? SessionFees { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public bool? IsFigCreated { get; set; }
}
