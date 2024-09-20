using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class ProductUserInteraction
{
    public Guid ProductUserInteractionId { get; set; }

    public Guid? ExhibitorProductId { get; set; }

    public Guid? UserId { get; set; }

    public string? Status { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? ConferenceId { get; set; }
}
