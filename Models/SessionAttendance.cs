using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class SessionAttendance
{
    public Guid SessionAttendanceId { get; set; }

    public string? TypeOfUser { get; set; }

    public Guid? ConferenceId { get; set; }

    public Guid? SessionId { get; set; }

    public DateTime? SessionDate { get; set; }

    public string? Status { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public Guid? UserId { get; set; }

    public string? SessionEventType { get; set; }

    public string? DeviceName { get; set; }

    public string? DeviceId { get; set; }
}
