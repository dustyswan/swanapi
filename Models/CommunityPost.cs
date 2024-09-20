using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class CommunityPost
{
    public Guid CommunityPostId { get; set; }

    public Guid? ConferenceId { get; set; }

    public int PostTypeId { get; set; }

    public int? PrivacyTypeId { get; set; }

    public string? Description { get; set; }

    public DateTime Date { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }

    public Guid? UserId { get; set; }
}
