using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class Menu
{
    public int MenuId { get; set; }

    public int? ParentMenuId { get; set; }

    public string? MenuName { get; set; }

    public string? MenuIcon { get; set; }

    public int? MenuType { get; set; }

    public int? SequenceNumber { get; set; }

    public string? Url { get; set; }

    public string? MenuDescription { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }
}
