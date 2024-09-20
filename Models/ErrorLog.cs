using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class ErrorLog
{
    public int ErrorId { get; set; }

    public string? ErrorMessage { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ErrorPath { get; set; }
}
