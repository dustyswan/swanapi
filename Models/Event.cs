using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class Event
{
    public Guid EventId { get; set; }

    public Guid ConferenceId { get; set; }

    public DateTime? EventStartdate { get; set; }

    public DateTime? EventEnddate { get; set; }

    public string? EventWebsite { get; set; }

    public string? ContactName { get; set; }

    public string? Email { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Status { get; set; }

    public string? CoverImage { get; set; }

    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }

    public decimal? AttendeeFees { get; set; }

    public string? DisplayImage { get; set; }

    public string? EventName { get; set; }

    public string? PriceType { get; set; }

    public string? Type { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public string? QrcodeImageUrl { get; set; }
}
