using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class AssociationProductDocument
{
    public Guid AssociationaProductDocumentsId { get; set; }

    public Guid? AssociationProductId { get; set; }

    public string? FileName { get; set; }

    public string? Documents { get; set; }

    public string? AttachmentType { get; set; }

    public string? AttachmentExtension { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
