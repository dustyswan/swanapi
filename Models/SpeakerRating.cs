using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class SpeakerRating
{
    public Guid SpeakerRatingId { get; set; }

    public Guid? SpeakerId { get; set; }

    public decimal? Rating { get; set; }

    public Guid? UserId { get; set; }

    public string? Feedback { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
