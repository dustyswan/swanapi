using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class SpeakerUploadedAttachment
{
    public Guid SpeakerDocumentId { get; set; }

    public Guid? SpeakerId { get; set; }

    public string? AttachmentType { get; set; }

    public string? AttachmentTitle { get; set; }

    public string? AttachmentPath { get; set; }

    public string? AttachmentExtension { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }
}
