using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class SentRequest
{
    public Guid SentRequestId { get; set; }

    public Guid SentRequestUserId { get; set; }

    public Guid ReceiveRequestUserId { get; set; }

    public string? Message { get; set; }

    public string Status { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime? CancelSentRequestOn { get; set; }

    public DateTime? AcceptedSentRequestOn { get; set; }
}
