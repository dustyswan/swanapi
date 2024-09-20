using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class ConferenceAttendeePriceType
{
    public Guid ConferenceAttendeePriceTypeId { get; set; }

    public Guid? ConferenceId { get; set; }

    public string? Name { get; set; }

    public decimal? Price { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
