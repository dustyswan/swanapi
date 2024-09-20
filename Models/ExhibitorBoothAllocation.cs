using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class ExhibitorBoothAllocation
{
    public Guid ExhibitorBoothAllocationId { get; set; }

    public Guid? BoothId { get; set; }

    public Guid? ConferenceId { get; set; }

    public Guid? UserId { get; set; }

    public int? BookingPrice { get; set; }

    public string? BoothStatus { get; set; }

    public Guid? BoothBookingPaymentId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }

    public Guid? CompanyId { get; set; }

    public bool? IsUnregister { get; set; }
}
