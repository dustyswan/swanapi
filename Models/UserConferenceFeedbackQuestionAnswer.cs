using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class UserConferenceFeedbackQuestionAnswer
{
    public Guid UserConferenceFeedbackQuestionAnswerId { get; set; }

    public Guid? UserConferenceFeedbackId { get; set; }

    public Guid? QuestionId { get; set; }

    public string? Answer { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }
}
