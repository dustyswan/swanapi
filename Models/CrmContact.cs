using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class CrmContact
{
    public Guid ContactId { get; set; }

    public string? Email { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? ContactOwner { get; set; }

    public string? JobTitle { get; set; }

    public string? PhoneNo { get; set; }

    public int? LifeCycleStageId { get; set; }

    public int? LeadStatusId { get; set; }

    public int? LeadBasisForProcessingContactDataId { get; set; }

    public bool? IsAllowYourTeamMarketContact { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
