using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class ConferenceTestimonialVideoOrAudioAllocation
{
    public Guid ConferenceTestimonialVideoOrAudioAllocationId { get; set; }

    public Guid? ConferenceTestimonialVideoOrAudioId { get; set; }

    public string? AttachmentType { get; set; }

    public string? AttachmentTitle { get; set; }

    public string? AttachmentPath { get; set; }

    public string? AttachmentExtension { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }
}
