using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class SalesRepresentativesOld1
{
    public Guid SalesRepresentativesId { get; set; }

    public string? Email { get; set; }

    public string? Image { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public Guid? CompanyId { get; set; }
}
