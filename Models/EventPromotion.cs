using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class EventPromotion
{
    public Guid EventPromotionId { get; set; }

    public string? EventImageUrl { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }

    public int? SequenceNo { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Type { get; set; }
}
