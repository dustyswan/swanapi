using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class UserMst
{
    public Guid UserId { get; set; }

    public int RoleId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string Email { get; set; } = null!;

    public string? Password { get; set; }

    public string? Phone { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public bool? IsRequestedPassword { get; set; }

    public int? ResetPasswordPin { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }

    public Guid? CompanyId { get; set; }

    public string? ProfileImage { get; set; }

    public string? UserType { get; set; }

    public bool? EmailConfirm { get; set; }

    public bool? IsCompleteProfile { get; set; }

    public string? JobTitle { get; set; }

    public string? WorkEmail { get; set; }

    public string? WorkPhone { get; set; }

    public string? Title { get; set; }

    public string? AboutMe { get; set; }

    public bool? IsFigCreated { get; set; }

    public bool? IsFigUser { get; set; }

    public string? DistrictName { get; set; }

    public Guid? FigUserId { get; set; }

    public bool? IsExternalUser { get; set; }

    public string? CoverPhoto { get; set; }

    public bool? IsReceivePushNotification { get; set; }

    public int? FigupdateFlag { get; set; }
    public int? isReceivedSMA { get; set; }

    public string? PreferredSMSNumber { get; set; }
}
