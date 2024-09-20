using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;
using swanapi.Data;

namespace swanapi.Models;

public partial class Association
{
    public Guid AssociationId { get; set; }

    public string? Name { get; set; }

    public string? Logo { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? ContactName { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? PaymentRemittanceAddress { get; set; }

    public string? PaymentCity { get; set; }

    public string? PaymentState { get; set; }

    public string? PaymentZip { get; set; }

    public string? Type { get; set; }

    public string? Website { get; set; }

    public bool? IsActive { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? PublicKey { get; set; }

    public string? SecretKey { get; set; }

    public string? Currency { get; set; }
}


public static class AssociationEndpoints
{
	public static void MapAssociationEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Association").WithTags(nameof(Association));

        group.MapGet("/", async (EventPlannerDbContext db) =>
        {
            return await db.Associations.ToListAsync();
        })
        .WithName("GetAllAssociations")
        .WithOpenApi();

        group.MapGet("/{id}", async Task<Results<Ok<Association>, NotFound>> (Guid associationid, EventPlannerDbContext db) =>
        {
            return await db.Associations.AsNoTracking()
                .FirstOrDefaultAsync(model => model.AssociationId == associationid)
                is Association model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetAssociationById")
        .WithOpenApi();

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (Guid associationid, Association association, EventPlannerDbContext db) =>
        {
            var affected = await db.Associations
                .Where(model => model.AssociationId == associationid)
                .ExecuteUpdateAsync(setters => setters
                  .SetProperty(m => m.AssociationId, association.AssociationId)
                  .SetProperty(m => m.Name, association.Name)
                  .SetProperty(m => m.Logo, association.Logo)
                  .SetProperty(m => m.Address, association.Address)
                  .SetProperty(m => m.City, association.City)
                  .SetProperty(m => m.State, association.State)
                  .SetProperty(m => m.Zip, association.Zip)
                  .SetProperty(m => m.ContactName, association.ContactName)
                  .SetProperty(m => m.Email, association.Email)
                  .SetProperty(m => m.Phone, association.Phone)
                  .SetProperty(m => m.PaymentRemittanceAddress, association.PaymentRemittanceAddress)
                  .SetProperty(m => m.PaymentCity, association.PaymentCity)
                  .SetProperty(m => m.PaymentState, association.PaymentState)
                  .SetProperty(m => m.PaymentZip, association.PaymentZip)
                  .SetProperty(m => m.Type, association.Type)
                  .SetProperty(m => m.Website, association.Website)
                  .SetProperty(m => m.IsActive, association.IsActive)
                  .SetProperty(m => m.CreatedBy, association.CreatedBy)
                  .SetProperty(m => m.CreatedOn, association.CreatedOn)
                  .SetProperty(m => m.UpdatedBy, association.UpdatedBy)
                  .SetProperty(m => m.UpdatedOn, association.UpdatedOn)
                  .SetProperty(m => m.PublicKey, association.PublicKey)
                  .SetProperty(m => m.SecretKey, association.SecretKey)
                  .SetProperty(m => m.Currency, association.Currency)
                  );
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateAssociation")
        .WithOpenApi();

        group.MapPost("/", async (Association association, EventPlannerDbContext db) =>
        {
            db.Associations.Add(association);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/Association/{association.AssociationId}",association);
        })
        .WithName("CreateAssociation")
        .WithOpenApi();

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (Guid associationid, EventPlannerDbContext db) =>
        {
            var affected = await db.Associations
                .Where(model => model.AssociationId == associationid)
                .ExecuteDeleteAsync();
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteAssociation")
        .WithOpenApi();
    }
}