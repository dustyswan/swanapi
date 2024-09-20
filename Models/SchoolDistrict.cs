using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class SchoolDistrict
{
    public Guid SchoolDistrictId { get; set; }

    public string? SiteCode { get; set; }

    public string? DistrictName { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? Country { get; set; }

    public string? State { get; set; }

    public string? City { get; set; }

    public string? PostalCode { get; set; }

    public bool? IsTermCondition { get; set; }

    public int? NoOfUsers { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }

    public string? DistrictLogo { get; set; }

    public bool? IsShareInfoToFigFamily { get; set; }

    public string? CoverImage { get; set; }

    public string? AboutUs { get; set; }

    public bool? IsPreferredPartners { get; set; }

    public bool? IsShowAsClientOnMainSite { get; set; }
}
