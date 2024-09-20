using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class OneWorldSyncProduct
{
    public long OneWorldSyncProductId { get; set; }

    public string? ProductName { get; set; }

    public string? CategoryName { get; set; }

    public string? SubCategory1Name { get; set; }

    public string? SubCategory2Name { get; set; }

    public string? Glnnumber { get; set; }

    public string? Ingredients { get; set; }

    public string? ProductDescription { get; set; }

    public string? Manufacturer { get; set; }

    public string? BrandName { get; set; }

    public string? Vendor { get; set; }

    public string? Gtin { get; set; }

    public string? Upc { get; set; }

    public string? StorageTypeName { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? Createdon { get; set; }

    public DateTime? Modifiedon { get; set; }

    public bool? IsApprove { get; set; }

    public bool? IsMerge { get; set; }

    public bool? IsProductSync { get; set; }

    public Guid? CompanyId { get; set; }
}
