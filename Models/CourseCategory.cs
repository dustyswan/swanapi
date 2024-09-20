using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class CourseCategory
{
    public Guid CourseCategoryId { get; set; }

    public string? CourseCategoryName { get; set; }

    public string? CourseCategoryCode { get; set; }

    public int? CategoryTypeId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }

    public virtual CategoryType? CategoryType { get; set; }
}
