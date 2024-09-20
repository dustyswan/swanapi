using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class CrmDealMst
{
    public Guid DealId { get; set; }

    public string? DealName { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? CategoryId { get; set; }

    public string? Description { get; set; }

    public string? Priority { get; set; }

    public Guid? UserId { get; set; }

    public decimal? Amount { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
