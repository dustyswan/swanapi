using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class AssociationProductImage
{
    public Guid AssociationProductImageId { get; set; }

    public Guid? AssociationProductId { get; set; }

    public string? FileName { get; set; }

    public string? Images { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
