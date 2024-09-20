using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class Class
{
    public Guid ClassesId { get; set; }

    public Guid? ConferenceId { get; set; }

    public Guid? EventId { get; set; }

    public string? Title { get; set; }

    public string? Descriptions { get; set; }

    public DateTime? ClassesStartdate { get; set; }

    public decimal? Ceus { get; set; }

    public decimal? Cost { get; set; }

    public string? Keyarea { get; set; }

    public string? TrainingTopic { get; set; }

    public string? Learningobjective { get; set; }

    public string? TargetAudienceCode { get; set; }

    public string? EndTime { get; set; }

    public string? StartTime { get; set; }

    public string? CoverImage { get; set; }

    public string? MeetingRoomNumber { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }

    public Guid? SpeakerId { get; set; }

    public string? QrcodeImageUrl { get; set; }
}
