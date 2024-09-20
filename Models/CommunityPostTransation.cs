using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class CommunityPostTransation
{
    public Guid CommunityPostTransactionId { get; set; }

    public Guid? CommunityPostId { get; set; }

    public string? AttachmentUrl { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }
}
