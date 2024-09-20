using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class ChatMst
{
    public Guid ChatId { get; set; }

    public Guid? UserIdOne { get; set; }

    public Guid? UserIdSecond { get; set; }

    public DateTime? StartedOnDate { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }

    public bool? IsDeletedBySendUserId { get; set; }

    public bool? IsDeletedByReceiverUserId { get; set; }
}
