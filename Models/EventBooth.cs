using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class EventBooth
{
    public Guid EventBoothsId { get; set; }

    public Guid? EventId { get; set; }

    public string? SeatEventNumber { get; set; }

    public string? SeatTextNumber { get; set; }

    public decimal? PositionX { get; set; }

    public decimal? PositionY { get; set; }

    public decimal? Hight { get; set; }

    public decimal? Width { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? LastUpdatedOn { get; set; }

    public Guid? LastUpdatedBy { get; set; }

    public int? SequenceNumber { get; set; }

    public string? Status { get; set; }

    public string? BoothStatus { get; set; }

    public decimal? Price { get; set; }

    public string? Type { get; set; }
}
