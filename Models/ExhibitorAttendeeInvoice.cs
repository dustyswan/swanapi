using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;
using swanapi.Data;

namespace swanapi.Models;

public partial class ExhibitorAttendeeInvoice
{
    public Guid ExhibitorAttendeeInvoiceId { get; set; }

    public string? IntentId { get; set; }

    public string? AddressLine1 { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PurchaseOrderNumber { get; set; }

    public string? ZipCode { get; set; }

    public string? InvoiceInstructions { get; set; }

    public decimal? TotalAmount { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public string? InvoiceStatus { get; set; }

    public Guid? ApproveOrRejectByUserId { get; set; }

    public DateTime? ApproveOrRejecteDate { get; set; }

    public string? UserType { get; set; }

    public Guid? ExhibitorOrAttendeePaymentId { get; set; }

    public DateTime? ReceivedPaymentDate { get; set; }

    public string? CheckNumber { get; set; }

    public bool? IsUnregister { get; set; }
}


public static class ExhibitorAttendeeInvoiceEndpoints
{
	public static void MapExhibitorAttendeeInvoiceEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/ExhibitorAttendeeInvoice").WithTags(nameof(ExhibitorAttendeeInvoice));

        group.MapGet("/", async (EventPlannerDbContext db) =>
        {
            return await db.ExhibitorAttendeeInvoices.ToListAsync();
        })
        .WithName("GetAllExhibitorAttendeeInvoices")
        .WithOpenApi();

        group.MapGet("/{id}", async Task<Results<Ok<ExhibitorAttendeeInvoice>, NotFound>> (Guid exhibitorattendeeinvoiceid, EventPlannerDbContext db) =>
        {
            return await db.ExhibitorAttendeeInvoices.AsNoTracking()
                .FirstOrDefaultAsync(model => model.ExhibitorAttendeeInvoiceId == exhibitorattendeeinvoiceid)
                is ExhibitorAttendeeInvoice model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetExhibitorAttendeeInvoiceById")
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (Guid exhibitorattendeeinvoiceid, ExhibitorAttendeeInvoice exhibitorAttendeeInvoice, EventPlannerDbContext db) =>
        {
            var affected = await db.ExhibitorAttendeeInvoices
                .Where(model => model.ExhibitorAttendeeInvoiceId == exhibitorattendeeinvoiceid)
                .ExecuteUpdateAsync(setters => setters
                  .SetProperty(m => m.ExhibitorAttendeeInvoiceId, exhibitorAttendeeInvoice.ExhibitorAttendeeInvoiceId)
                  .SetProperty(m => m.IntentId, exhibitorAttendeeInvoice.IntentId)
                  .SetProperty(m => m.AddressLine1, exhibitorAttendeeInvoice.AddressLine1)
                  .SetProperty(m => m.Name, exhibitorAttendeeInvoice.Name)
                  .SetProperty(m => m.Email, exhibitorAttendeeInvoice.Email)
                  .SetProperty(m => m.Phone, exhibitorAttendeeInvoice.Phone)
                  .SetProperty(m => m.City, exhibitorAttendeeInvoice.City)
                  .SetProperty(m => m.State, exhibitorAttendeeInvoice.State)
                  .SetProperty(m => m.PurchaseOrderNumber, exhibitorAttendeeInvoice.PurchaseOrderNumber)
                  .SetProperty(m => m.ZipCode, exhibitorAttendeeInvoice.ZipCode)
                  .SetProperty(m => m.InvoiceInstructions, exhibitorAttendeeInvoice.InvoiceInstructions)
                  .SetProperty(m => m.TotalAmount, exhibitorAttendeeInvoice.TotalAmount)
                  .SetProperty(m => m.IsActive, exhibitorAttendeeInvoice.IsActive)
                  .SetProperty(m => m.CreatedOn, exhibitorAttendeeInvoice.CreatedOn)
                  .SetProperty(m => m.CreatedBy, exhibitorAttendeeInvoice.CreatedBy)
                  .SetProperty(m => m.UpdatedOn, exhibitorAttendeeInvoice.UpdatedOn)
                  .SetProperty(m => m.UpdatedBy, exhibitorAttendeeInvoice.UpdatedBy)
                  .SetProperty(m => m.InvoiceStatus, exhibitorAttendeeInvoice.InvoiceStatus)
                  .SetProperty(m => m.ApproveOrRejectByUserId, exhibitorAttendeeInvoice.ApproveOrRejectByUserId)
                  .SetProperty(m => m.ApproveOrRejecteDate, exhibitorAttendeeInvoice.ApproveOrRejecteDate)
                  .SetProperty(m => m.UserType, exhibitorAttendeeInvoice.UserType)
                  .SetProperty(m => m.ExhibitorOrAttendeePaymentId, exhibitorAttendeeInvoice.ExhibitorOrAttendeePaymentId)
                  .SetProperty(m => m.ReceivedPaymentDate, exhibitorAttendeeInvoice.ReceivedPaymentDate)
                  .SetProperty(m => m.CheckNumber, exhibitorAttendeeInvoice.CheckNumber)
                  .SetProperty(m => m.IsUnregister, exhibitorAttendeeInvoice.IsUnregister)
                  );
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateExhibitorAttendeeInvoice")
        .WithOpenApi();

        group.MapPost("/", async (ExhibitorAttendeeInvoice exhibitorAttendeeInvoice, EventPlannerDbContext db) =>
        {
            db.ExhibitorAttendeeInvoices.Add(exhibitorAttendeeInvoice);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/ExhibitorAttendeeInvoice/{exhibitorAttendeeInvoice.ExhibitorAttendeeInvoiceId}",exhibitorAttendeeInvoice);
        })
        .WithName("CreateExhibitorAttendeeInvoice")
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (Guid exhibitorattendeeinvoiceid, EventPlannerDbContext db) =>
        {
            var affected = await db.ExhibitorAttendeeInvoices
                .Where(model => model.ExhibitorAttendeeInvoiceId == exhibitorattendeeinvoiceid)
                .ExecuteDeleteAsync();
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteExhibitorAttendeeInvoice")
        .WithOpenApi();
    }
}