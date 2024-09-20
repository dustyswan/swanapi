using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class OneWorldSyncProductImage
{
    public long OneWorldSyncProductImageId { get; set; }

    public long? OneWorldSyncProductId { get; set; }

    public string? ImageUrl { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }
}
