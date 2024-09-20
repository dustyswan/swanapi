using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class CommunityComment
{
    public Guid CommunityCommentId { get; set; }

    public Guid? CommunityPostId { get; set; }

    public string? Comment { get; set; }

    public Guid? CommentByUserId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? LastUpdatedOn { get; set; }
}
