using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class CrmAttachment
{
    public Guid AttachmentId { get; set; }

    public Guid? CommonId { get; set; }

    public string? Type { get; set; }

    public string? ImageUrl { get; set; }

    public string? ImageName { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
