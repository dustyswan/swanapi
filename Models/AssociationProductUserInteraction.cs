using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class AssociationProductUserInteraction
{
    public Guid AssociationProductUserInteractionId { get; set; }

    public Guid? AssociationProductId { get; set; }

    public Guid? UserId { get; set; }

    public string? Status { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
