using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class Question
{
    public Guid QuestionId { get; set; }

    public string? QuestionTitle { get; set; }

    public bool? IsRequired { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? UserId { get; set; }

    public string? QuestionType { get; set; }

    public bool? IsSpeakerDropDown { get; set; }

    public string? QuestionCategory { get; set; }

    public Guid? CompanyId { get; set; }
}
