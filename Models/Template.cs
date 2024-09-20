using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class Template
{
    public Guid TemplateId { get; set; }

    public string? TemplateTitle { get; set; }

    public string? NotificationType { get; set; }

    public string? Subject { get; set; }

    public string? Body { get; set; }

    public string? FieldsUsedNotes { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public string? TemplateLanguage { get; set; }

    public string? TemplateType { get; set; }

    public string? RequireParameter { get; set; }
}
