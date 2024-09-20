using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class UserMealAllocation
{
    public Guid UserMealAllocationId { get; set; }

    public Guid? UserId { get; set; }

    public string? Meal { get; set; }

    public string? OtherDescription { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
