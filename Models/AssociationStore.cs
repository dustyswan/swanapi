using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class AssociationStore
{
    public Guid AssociationStoreId { get; set; }

    public Guid? AssociationId { get; set; }

    public string? StoreName { get; set; }

    public string? Description { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool? IsActive { get; set; }
}
