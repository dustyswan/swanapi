using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class AttendeeFavoriteProduct
{
    public Guid AttendeeFavoriteProductId { get; set; }

    public Guid? AttendeeId { get; set; }

    public Guid? ProductId { get; set; }

    public Guid? ExhibitorId { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? ConferenceId { get; set; }

    public Guid? AssociationMembersId { get; set; }

    public string? LeadStatus { get; set; }

    public bool? IsContacted { get; set; }

    public string? OtherAssociationMembersName { get; set; }

    public Guid? RequestAcallUserInformationId { get; set; }

    public Guid? CompanyId { get; set; }
}
