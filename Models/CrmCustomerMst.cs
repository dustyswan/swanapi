using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class CrmCustomerMst
{
    public Guid CustomerId { get; set; }

    public Guid? CompanyId { get; set; }

    public string? CustomerName { get; set; }

    public string? ContactNo { get; set; }

    public string? Email { get; set; }

    public string? MainContactTitle { get; set; }

    public string? WebSite { get; set; }

    public string? MainContactEmail { get; set; }

    public string? MainContactName { get; set; }

    public string? MainContactOfficeNo { get; set; }

    public string? MainContactMobileNo { get; set; }

    public string? MainContactOtherNo { get; set; }

    public string? Addess { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? ZipCode { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
