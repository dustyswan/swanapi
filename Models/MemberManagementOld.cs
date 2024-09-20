using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class MemberManagementOld
{
    public Guid MemberManagementId { get; set; }

    public Guid? ConferenceId { get; set; }

    public string? OrganizationOrAttendeeType { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public int? ConferenceMembersAttendee { get; set; }

    public decimal? ConferenceMembersPrice { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public decimal? TotalPrice { get; set; }

    public Guid? AssociationId { get; set; }

    public int? MealCount { get; set; }

    public Guid? AssociationMemberId { get; set; }
}
