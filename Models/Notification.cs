using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class Notification
{
    public Guid NotificationId { get; set; }

    public string? NotificationType { get; set; }

    public string? NotificationText { get; set; }

    public Guid? UserId { get; set; }

    public bool? IsRead { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public string? Token { get; set; }

    public Guid? UniqueId { get; set; }
}
