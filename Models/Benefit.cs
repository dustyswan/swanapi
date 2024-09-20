using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class Benefit
{
    public Guid BenefitId { get; set; }

    public Guid? ExhibitorProductId { get; set; }

    public string? BenefitTitle { get; set; }

    public string? BenefitDescription { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
