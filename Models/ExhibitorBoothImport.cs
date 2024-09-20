using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class ExhibitorBoothImport
{
    public Guid? ConferenceId { get; set; }

    public Guid? BoothBookingPaymentId { get; set; }

    public Guid? FigboothGuidid { get; set; }

    public string? BoothNumber { get; set; }

    public string? BoothCount { get; set; }

    public string? CompanyName { get; set; }

    public Guid? CompanyGuidid { get; set; }

    public string? ContactName { get; set; }

    public Guid? UserId { get; set; }

    public string? Email { get; set; }

    public string? BrokerCompany { get; set; }

    public Guid? BrokerCompanyGuidId { get; set; }

    public string? BrokerContactName { get; set; }

    public string? BrokerEmail { get; set; }

    public Guid? BrokerUserId { get; set; }

    public string? CompanyContactAtExpo { get; set; }

    public string? Status { get; set; }

    public decimal? BoothFee { get; set; }

    public decimal? Balance { get; set; }

    public string? Notes { get; set; }

    public string? LogoFile { get; set; }
}
