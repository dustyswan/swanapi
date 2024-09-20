using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class ConferenceStoreItem
{
    public Guid ConferenceStoreItemsId { get; set; }

    public Guid? ConferenceId { get; set; }

    public Guid? EventId { get; set; }

    public string? ItemImage { get; set; }

    public string? ItemTitle { get; set; }

    public string? ItemDescription { get; set; }

    public decimal? ItemPrice { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
