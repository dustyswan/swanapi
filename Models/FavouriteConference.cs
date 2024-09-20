using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class FavouriteConference
{
    public Guid FavouriteConferenceId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? ConferenceId { get; set; }

    public bool? IsFavourite { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
