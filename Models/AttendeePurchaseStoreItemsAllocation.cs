using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class AttendeePurchaseStoreItemsAllocation
{
    public Guid AttendeePurchaseStoreItemsAllocationId { get; set; }

    public Guid? ConferenceStoreItemsId { get; set; }

    public Guid? ConferenceId { get; set; }

    public Guid? EventId { get; set; }

    public Guid? UserId { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public decimal? ItemPrice { get; set; }

    public Guid? AttendeePaymentId { get; set; }
}
