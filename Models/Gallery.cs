using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class Gallery
{
    public Guid GalleryId { get; set; }

    public string? Title { get; set; }

    public string? Image { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
