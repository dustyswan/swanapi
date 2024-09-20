using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class ExhibitorPlatformFeesPayment
{
    public Guid ExhibitorPlatformFeesPaymentId { get; set; }

    public Guid? UserId { get; set; }

    public int? PriceId { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }
}
