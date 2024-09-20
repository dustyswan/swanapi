using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class EmailPreference
{
    public Guid UserId { get; set; }

    public bool? WhenSomeoneMentionsThemInCommentOrPost { get; set; }

    public bool? WhenTheyIsRecevieMessage { get; set; }

    public bool? WhenSomeoneSendsThemIsConnectionRequest { get; set; }

    public bool? WhenSomeoneAcceptsTheirIsConnectionRequest { get; set; }

    public bool? WhenTheyChangeTheirIsPassword { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public bool? WhenTheyCreateIsPost { get; set; }

    public bool? WhenSomeOneBlockPost { get; set; }

    public bool? WhenTheyBlockPostDelete { get; set; }
}
