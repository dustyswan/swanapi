using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class PostType
{
    public int PostTypeId { get; set; }

    public string? PostType1 { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }
}
