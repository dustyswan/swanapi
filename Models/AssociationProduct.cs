using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class AssociationProduct
{
    public Guid AssociationProductId { get; set; }

    public Guid? AssociationStoreId { get; set; }

    public Guid? AssociationId { get; set; }

    public decimal? Price { get; set; }

    public string? ProductName { get; set; }

    public string? ShortDescription { get; set; }

    public string? CategoryName { get; set; }

    public string? Glnnumber { get; set; }

    public string? Ingredients { get; set; }

    public string? Manufacturer { get; set; }

    public string? BrandName { get; set; }

    public string? Gtin { get; set; }

    public string? Upc { get; set; }

    public int? OwsproductId { get; set; }

    public bool? IsApprove { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? SubCategoryName { get; set; }

    public bool? IsExhibitorProduct { get; set; }

    public bool? IsDiscountedProduct { get; set; }

    public string? DiscountedType { get; set; }

    public decimal? DiscountedValue { get; set; }

    public decimal? TotalProductPrice { get; set; }
}
