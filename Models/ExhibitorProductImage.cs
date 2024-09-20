using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class ExhibitorProductImage
{
    public Guid ExhibitorProductImageId { get; set; }

    public Guid? ExhibitorProductId { get; set; }

    public string? FileName { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? Images { get; set; }
}
