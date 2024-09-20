using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class Conference
{
    public Guid ConferenceId { get; set; }

    public string Email { get; set; } = null!;

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }

    public string? AccountNumber { get; set; }

    public decimal? AttendeeFees { get; set; }

    public string? BankRoutingNumber { get; set; }

    public DateTime? BookingStartDate { get; set; }

    public string? City { get; set; }

    public string? ConferenceAddress { get; set; }

    public DateTime? ConferenceEnddate { get; set; }

    public string? ConferenceName { get; set; }

    public DateTime? ConferenceStartdate { get; set; }

    public string? ConferenceWebsite { get; set; }

    public string? ContactName { get; set; }

    public string? CoverImage { get; set; }

    public string? Description { get; set; }

    public string? DisplayImage { get; set; }

    public decimal? ExhibitorFees { get; set; }

    public int? Height { get; set; }

    public string? PhoneNumber { get; set; }

    public string? PriceType { get; set; }

    public int? State { get; set; }

    public string? Status { get; set; }

    public string? Teamcondition { get; set; }

    public int? Width { get; set; }

    public string? Zip { get; set; }

    public string? PublicKey { get; set; }

    public string? SecretKey { get; set; }

    public string? Currency { get; set; }

    public string? PaymentAddress { get; set; }

    public bool? IsExternalConference { get; set; }

    public bool? IsExhibitorRegister { get; set; }

    public bool? IsAttendeeRegister { get; set; }

    public string? VideoAudioDescription { get; set; }
}
