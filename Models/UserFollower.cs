using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class UserFollower
{
    public Guid UserFollowersId { get; set; }

    public Guid? UserId { get; set; }

    public Guid FolloweByUserId { get; set; }

    public DateTime? FollowDate { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }
}
