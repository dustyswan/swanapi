using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class SessionSpeakerAllocation
{
    public Guid SessionSpeakerAllocationId { get; set; }

    public Guid? SessionId { get; set; }

    public Guid? SpeakerId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }
}
