using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class BoothAllocation
{
    public Guid BoothAllocationId { get; set; }

    public Guid? EventId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? BoothId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }

    public Guid? ConferenceBookingId { get; set; }
}
