using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class Speaker
{
    public Guid SpeakerId { get; set; }

    public string? SpeakerName { get; set; }

    public string? SpeakerImage { get; set; }

    public string? SpeakerDesignations { get; set; }

    public string? SpeakerIntroductions { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }

    public string? Address { get; set; }

    public string? AttachmentType { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? VideoClip { get; set; }

    public string? VideoClipUrl { get; set; }

    public string? Website { get; set; }

    public string? Password { get; set; }

    public bool? EmailConfirm { get; set; }

    public bool? IsRequestedPassword { get; set; }

    public int? ResetPasswordPin { get; set; }

    public string? Biography { get; set; }

    public string? Ribbon { get; set; }
}
