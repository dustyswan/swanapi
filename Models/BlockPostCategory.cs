using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class BlockPostCategory
{
    public Guid BlockPostCategoryId { get; set; }

    public string? BlockPostCategoryName { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }
}
