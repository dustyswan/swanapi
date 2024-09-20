using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class ExhibitorProduct
{
    public Guid ExhibitorProductId { get; set; }

    public string? ProductName { get; set; }

    public string? ProductImage { get; set; }

    public string? ShortDescription { get; set; }

    public bool? IsAactive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? CompanyId { get; set; }

    public string? CategoryName { get; set; }

    public string? Ingredients { get; set; }

    public string? Manufacturer { get; set; }

    public string? BrandName { get; set; }

    public string? Gtin { get; set; }

    public string? Upc { get; set; }

    public string? Glnnumber { get; set; }

    public int? OwsproductId { get; set; }

    public bool? IsApprove { get; set; }
}
