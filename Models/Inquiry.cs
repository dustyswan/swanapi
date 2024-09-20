using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class Inquiry
{
    public Guid InquiryId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Description { get; set; }

    public string? SchoolDistrictName { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }
}
