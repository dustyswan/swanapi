using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class ConferenceTestimonialVideoOrAudio
{
    public Guid ConferenceTestimonialVideoOrAudioId { get; set; }

    public Guid? ConferenceId { get; set; }

    public Guid? UserId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? SchoolDistrictOrOrganization { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }
}
