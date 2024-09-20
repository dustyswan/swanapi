using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class UserQuestionAnswer
{
    public Guid UserQuestionAnswerId { get; set; }

    public Guid? QuestionId { get; set; }

    public Guid? UserId { get; set; }

    public string? Answer { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool? IsContacted { get; set; }

    public Guid? ConferenceId { get; set; }

    public string? OtherExternalConference { get; set; }

    public Guid? ExhibitorId { get; set; }

    public Guid? RequestAcallUserInformationId { get; set; }

    public Guid? CompanyId { get; set; }
}
