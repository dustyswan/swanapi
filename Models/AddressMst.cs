using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class AddressMst
{
    public Guid AddressId { get; set; }

    public Guid UserId { get; set; }

    public string? CompanyName { get; set; }

    public bool? IsPrimary { get; set; }

    public string? AddressType { get; set; }

    public string? Address1 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }
}
