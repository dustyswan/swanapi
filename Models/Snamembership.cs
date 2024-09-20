using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class Snamembership
{
    public Guid? SnamemberId { get; set; }

    public string SnamembershipNumber { get; set; } = null!;

    public string? FiguserId { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? MemberType { get; set; }

    public DateOnly? PaidThruDate { get; set; }

    public string? Title { get; set; }

    public string? DistrictSchool { get; set; }

    public string? District { get; set; }

    public string? Chapter { get; set; }

    public string? PreferredMailingAddress { get; set; }

    public string? PreferredCity { get; set; }

    public string? PreferredState { get; set; }

    public string? PreferredZip { get; set; }

    public string? WorkPhone { get; set; }

    public string? HomePhone { get; set; }

    public string? Email { get; set; }

    public string? WorkAddress { get; set; }

    public string? WorkCity { get; set; }

    public string? WorkState { get; set; }

    public string? WorkZip { get; set; }

    public string? HomeAddress { get; set; }

    public string? HomeCity { get; set; }

    public string? HomeState { get; set; }

    public string? HomeZip { get; set; }

    public string? PreferredAddress { get; set; }

    public string? UsCongress { get; set; }

    public string? ReferredBy { get; set; }

    public DateOnly? JoinDate { get; set; }

    public string? LastDuesPaidAmount { get; set; }

    public DateOnly? LastDuesPaymentDate { get; set; }

    public DateOnly? InfoLastUpdated { get; set; }

    public string? Sdm { get; set; }

    public string? SdmAdministrator { get; set; }

    public string? CertLevel { get; set; }

    public DateOnly? CertExpDate { get; set; }

    public string? Sns { get; set; }

    public bool? Updated { get; set; }

    public string? Leaid { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public Guid? LeaguidId { get; set; }

    public Guid? UserId { get; set; }
}
