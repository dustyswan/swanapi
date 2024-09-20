using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class SpeakerSpeechesAndTopicsAllocation
{
    public Guid SpeakerSpeechesAndTopicsAllocationId { get; set; }

    public Guid? SpeakerId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }
}
