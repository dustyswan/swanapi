using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class ConferenceFeedbackQuestionAllocation
{
    public Guid ConferenceFeedbackQuestionAllocationId { get; set; }

    public Guid? SubmittedId { get; set; }

    public Guid? ConferenceId { get; set; }

    public Guid? QuestionId { get; set; }

    public string? SendUserType { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
