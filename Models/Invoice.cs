using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class Invoice
{
    public Guid InvoicesId { get; set; }

    public string? Email { get; set; }

    public string? PurchaseOrderNumber { get; set; }

    public string? IntentId { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? Address { get; set; }

    public bool? IsFigCreated { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? UpdatesOn { get; set; }

    public Guid? UpdatedBy { get; set; }
}
