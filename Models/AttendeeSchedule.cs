using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class AttendeeSchedule
{
    public Guid AttendeeScheduleId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? ConferenceId { get; set; }

    public Guid? SessionOrEventId { get; set; }

    public string? Type { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }
}
