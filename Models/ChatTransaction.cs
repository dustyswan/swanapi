using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class ChatTransaction
{
    public Guid ChatTransactionId { get; set; }

    public Guid? ChatId { get; set; }

    public Guid? SenderUserId { get; set; }

    public Guid? ReceiverUserId { get; set; }

    public string? MessageType { get; set; }

    public string? MessageText { get; set; }

    public string? AttachmentUrl { get; set; }

    public bool? IsReadByReceiver { get; set; }

    public bool? IsDeletedBySendUserId { get; set; }

    public bool? IsDeletedByReceiverUserId { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }
}
