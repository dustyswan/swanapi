using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class CategoryType
{
    public int CategoryTypeId { get; set; }

    public string? TypeName { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }

    public virtual ICollection<CourseCategory> CourseCategories { get; set; } = new List<CourseCategory>();
}
