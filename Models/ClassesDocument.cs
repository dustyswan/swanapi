using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class ClassesDocument
{
    public Guid ClassesDocumnetId { get; set; }

    public Guid? ClassesId { get; set; }

    public string? FileName { get; set; }

    public string? DocumentType { get; set; }

    public string? DocumentPath { get; set; }

    public string? FileType { get; set; }

    public string? FileLength { get; set; }

    public int? FileSize { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }

    public Guid? SpeakerId { get; set; }
}
