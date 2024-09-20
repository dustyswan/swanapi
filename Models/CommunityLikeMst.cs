using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class CommunityLikeMst
{
    public Guid CommunityLikeId { get; set; }

    public Guid? CommunityPostId { get; set; }

    public bool? IsLiked { get; set; }

    public Guid? LikedByUserId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }
}
