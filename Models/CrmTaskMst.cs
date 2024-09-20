using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class CrmTaskMst
{
    public Guid TaskId { get; set; }

    public Guid? CompanyId { get; set; }

    public int? TaskTypeId { get; set; }

    public string? Priority { get; set; }

    public string? TaskName { get; set; }

    public DateTime? DeadLineDate { get; set; }

    public int? CommunicationPurposeId { get; set; }

    public int? CustomerId { get; set; }

    public string? ContactName { get; set; }

    public string? Remark { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
