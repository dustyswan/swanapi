using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class VwBoothsforOhio
{
    public string? CompanyName { get; set; }

    public string? CompanyEmail { get; set; }

    public string? CompanyPhone { get; set; }

    public string? BoothNumber { get; set; }

    public decimal? PositionX { get; set; }

    public decimal? PositionY { get; set; }

    public decimal? Height { get; set; }

    public decimal? Width { get; set; }

    public int? BookingPrice { get; set; }

    public string? CreatedByFirstName { get; set; }

    public string? CreatedByLastName { get; set; }

    public string CreatedByEmail { get; set; } = null!;
}
