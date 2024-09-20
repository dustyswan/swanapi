using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class PublicNotification
{
    public Guid PublicNotificationId { get; set; }

    public string? EventName { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? ConferenceId { get; set; }
}
