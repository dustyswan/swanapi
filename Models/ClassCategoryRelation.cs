using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class ClassCategoryRelation
{
    public Guid ClassCategoryRelationId { get; set; }

    public Guid? ClassesId { get; set; }

    public Guid? ClassCategoryId { get; set; }

    public int? CategoryTypeId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }
}
