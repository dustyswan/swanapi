using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class BlockReportPost
{
    public Guid PostBlockReportId { get; set; }

    public Guid? PostId { get; set; }

    public string? BlockCategories { get; set; }

    public string? BlockingReason { get; set; }

    public Guid? RequestedBy { get; set; }

    public string? PostType { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DeletePostReason { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
