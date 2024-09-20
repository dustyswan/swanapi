using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class ReceiveRequest
{
    public Guid ReceivedRequestId { get; set; }

    public Guid ReceivedRequestUserId { get; set; }

    public Guid SentRequestUserId { get; set; }

    public string? Message { get; set; }

    public string Status { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? CancelReceiveRequestOn { get; set; }
}
