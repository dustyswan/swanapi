using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class EventsLog
{
    public Guid LogId { get; set; }

    public string? Email { get; set; }

    public Guid? UserId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public Guid? CompanyId { get; set; }

    public string? Type { get; set; }

    public string? Description { get; set; }

    public DateTime? SentOn { get; set; }

    public string? Status { get; set; }

    public string? ErrorMessage { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }
}
