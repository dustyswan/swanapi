using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class QuestionOption
{
    public Guid OptionId { get; set; }

    public Guid? QuestionId { get; set; }

    public string? Option { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }
}
