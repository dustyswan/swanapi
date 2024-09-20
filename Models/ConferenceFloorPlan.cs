using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class ConferenceFloorPlan
{
    public Guid ConferenceFloorPlanId { get; set; }

    public Guid? EventId { get; set; }

    public string? FloorPlanLogo { get; set; }

    public string? FloorPlanTitle { get; set; }

    public string? Description { get; set; }

    public string? PdfLayout { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }
}
