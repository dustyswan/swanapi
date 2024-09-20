using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class EventBooking
{
    public Guid EventBookingId { get; set; }

    public Guid? CompanyId { get; set; }

    public int? BookingPrice { get; set; }

    public string? Status { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }

    public Guid? ConferenceId { get; set; }

    public string? ShortDescription { get; set; }

    public string? Title { get; set; }

    public string? UserType { get; set; }
}
