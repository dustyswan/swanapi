using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class ExhibitorProfileView
{
    public Guid ExhibitorProfileViewId { get; set; }

    public Guid? ExhibitorId { get; set; }

    public Guid? UserId { get; set; }

    public string? UserType { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
