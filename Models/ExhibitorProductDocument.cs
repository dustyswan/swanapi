using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class ExhibitorProductDocument
{
    public Guid ExhibitorProductDocumentsId { get; set; }

    public Guid? ExhibitorProductId { get; set; }

    public string? FileName { get; set; }

    public string? Documents { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? AttachmentType { get; set; }

    public string? AttachmentExtension { get; set; }
}
