using System;
using System.Collections.Generic;

namespace swanapi.Models;

public partial class StripeReview
{
    public string? Id { get; set; }

    public DateTime CreatedDateUtc { get; set; }

    public double Amount { get; set; }

    public double? AmountRefunded { get; set; }

    public string Currency { get; set; } = null!;

    public string? Captured { get; set; }

    public double? ConvertedAmount { get; set; }

    public double? ConvertedAmountRefunded { get; set; }

    public string? ConvertedCurrency { get; set; }

    public string Description { get; set; } = null!;

    public double? Fee { get; set; }

    public string? StatementDescriptor { get; set; }

    public string Status { get; set; } = null!;

    public string? SellerMessage { get; set; }

    public byte? TaxesOnFee { get; set; }

    public string? CardId { get; set; }

    public string? CustomerId { get; set; }

    public string? CustomerDescription { get; set; }

    public string? CustomerEmail { get; set; }

    public string? InvoiceId { get; set; }

    public string? Transfer { get; set; }

    public string? SubmissionIdMetadata { get; set; }

    public string? FormIdMetadata { get; set; }

    public string? TransactionTypeMetadata { get; set; }
}
