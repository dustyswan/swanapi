using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class RequestAcallUserInformation
{
    public Guid RequestAcallUserInformationId { get; set; }

    public Guid? UserId { get; set; }

    public Guid? ExhibitorId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public Guid? ConferenceId { get; set; }

    public Guid? AssociationMemberId { get; set; }

    public string? OtherConferenceName { get; set; }

    public string? OtherAssociationMemberName { get; set; }

    public bool? IsContacted { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool? IsChatWithExhibitor { get; set; }

    public Guid? CompanyId { get; set; }
}
